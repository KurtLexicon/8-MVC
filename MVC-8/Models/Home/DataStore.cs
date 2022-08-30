using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.Linq;

namespace MVC_8.Models.Home {
    public class DataStore {
        public class PersonNotFoundException: Exception {};

        private ApplicationDbContext DbContext { get; set; }

        public DataStore(ApplicationDbContext dbContext) {
            DbContext = dbContext;
        }

        public Person GetPersonById(int id) {
            Person? person = DbContext
                .People
                .FirstOrDefault(person => person.Id == id);
            if (person == null) throw new PersonNotFoundException();
            return person;
        }

        public int GetNumberOfPeople() {
            return DbContext.People.Count();
        }

        public List<Person> GetPeopleFiltered(string filter) {
            // var all = string.IsNullOrEmpty(filter);
            var people = DbContext.People;
            var where = string.IsNullOrEmpty(filter) ?
                people : people.Where(p => p.Name.Contains(filter) || p.City.Contains(filter));
            var list = where.ToList();
            return list;
        }

        public Person AddPerson(Person person) {
            DbContext.People.Add(person);
            DbContext.SaveChanges();
            return person;
        }

        public Person UpdatePerson(CreatePersonViewModel input) {
            Person person = GetPersonById(input.Id);
            person.UpdateFromInput(input);
            DbContext.SaveChanges();
            return person;
        }

        public void DeletePerson(int id) {
            Person person = GetPersonById(id);
            // DbContext.People.Attach(person);
            DbContext.People.Remove(person);
            DbContext.SaveChanges();
        }

        static private bool FilteredPerson(Person person, string filter) {
            bool ret = string.IsNullOrWhiteSpace(filter);
            ret = ret || person.Name.Contains(filter, StringComparison.CurrentCultureIgnoreCase);
            ret = ret || person.City.Contains(filter, StringComparison.CurrentCultureIgnoreCase);
            return ret;
        }
    }
}
