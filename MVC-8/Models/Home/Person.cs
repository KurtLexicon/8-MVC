using System.ComponentModel.DataAnnotations;


namespace MVC_8.Models.Home {
    public class Person {
        public int Id { get; private set; }
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public string Phone { get; set; } = "";

        public int SetId () {
            if(Id == 0) {
                Id = PeopleData.GetNextId();
            }
            return Id;
        }

        public Person() {
            Id = 0;
            Name = "";
            City = "";
            Phone = "";
        }

        public Person(string name, string city, string phone) {
            Id = PeopleData.GetNextId();
            Name = name;
            City = city;
            Phone = phone;
        }

        public Person(CreatePersonViewModel input) {
            Id = PeopleData.GetNextId();
            if (input != null) {
                Name = input.Name;
                City = input.City;
                Phone = input.Phone;
            } else {
                Name = "";
                City = "";
                Phone = "";
            }
        }
    }
}
