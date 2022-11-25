using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_8.Models
{
    public class PersonApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public List<int> LanguageIds { get; set; }

        public PersonApiModel(
            Person item)
        {
            Id = item.Id;
            Name = item.Name;
            CityId = item.CityId;
            CityName = item.City.Name;
            CountryName = item.City.Country.Name;
            Phone = item.Phone;
            LanguageIds = item.Languages.Select(x => x.Id).ToList();
        }
    }
}
