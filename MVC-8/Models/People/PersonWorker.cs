using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models
{
    public class PersonWorker
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreItem<Person> Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.Person;

        public PersonWorker(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Ds = new DataStorePeople(dbContext, dbContext.People);
        }

        public List<Person> GetItemsList(string filter)
        {
            List<Person> items = Ds.GetTypedItemsFiltered(filter);
            foreach (Person item in items)
            {
                item.City.People = new();
                item.City.Country.Cities = new();
                foreach (Language language in item.Languages)
                {
                    language.People = new();
                }
            }
            return items;
        }

        public PersonListViewModel GetList(string filter)
        {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filter);
            PersonListViewModel model = new();
            model.AddData(items, nTotal, filter);
            return model;
        }

        public Person GetItem(int id)
        {
            try
            {
                return id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException)
            {
                throw new InfoException($"{Entity.Name} {id} not found");
            }
        }

        public PersonViewModel GetItemModel(int id)
        {
            string errorMessage = "";
            Person item;
            try
            {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException)
            {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            PersonViewModel model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
            model.AddFail(errorMessage);
            return model;
        }

        public PersonViewModel AddItem(PersonViewModel input)
        {
            // Person item = Ds.GetItemById(input.Id);
            if (null == DbContext.Cities.FirstOrDefault(city => city.Id == input.CityId))
            {
                throw new InfoException("The city does not exist");
            }

            List<Language> languages = Ds.GetItemsByIds(Ds.Languages, input.LanguageIds);
            Person person = input.GetItem(languages);
            Person item = Ds.AddItem(person);

            PersonViewModel model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
            model.AddSuccess($"{Entity.Name} {item.Id} added");
            return model;
        }

        public PersonViewModel AddRandomItem()
        {
            List<City> cities = Ds.Cities.ToList();
            List<Language> languages = Ds.Languages.ToList();

            Person person = InitData.GetRandomPerson(cities, languages);
            Ds.AddItem(person);

            PersonViewModel model = new(person, cities, languages);
            model.AddSuccess($"{Const.Person.Name} {person.Id} added");
            return model;
        }

        public PersonViewModel UpdateItem(PersonViewModel input)
        {
            Person? item = DbContext.People.FirstOrDefault(item => item.Id == input.Id);
            if (item == null)
            {
                throw new InfoException($"{Entity.Name} {input.Id} not found");
            }

            item.Name = input.Name;
            item.Phone = input.Phone;
            item.City = Ds.GetItemById(Ds.Cities, input.CityId);
            item.CityId = input.CityId;
            item.Languages = Ds.GetItemsByIds(Ds.Languages, input.LanguageIds);
            Ds.SaveChanges();

            PersonViewModel model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
            model.AddSuccess($"{Entity.Name} {item.Id} updated");
            return model;
        }

        public SharedViewModel DeleteItem(int id)
        {
            Ds.DeleteItem(id);
            SharedViewModel ret = new();
            return ret.AddSuccess("The item is deleted");
        }
    }
}
