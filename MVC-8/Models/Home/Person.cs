using System.ComponentModel.DataAnnotations;


namespace MVC_8.Models.Home {
    public class Person {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public string Phone { get; set; } = "";

        public Person() {
            Id = 0;
            Name = "";
            City = "";
            Phone = "";
        }

        public Person(string name, string city, string phone, int id = 0) {
            Name = name;
            City = city;
            Phone = phone;
            Id = id;    
        }

        public Person(CreatePersonViewModel input) {
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

        public Person UpdateFromInput(CreatePersonViewModel input) {
            City = input.City;
            Name = input.Name;
            Phone = input.Phone;
            return this;
        }
    }
}
