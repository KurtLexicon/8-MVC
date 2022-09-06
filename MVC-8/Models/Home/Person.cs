namespace MVC_8.Models.Home {
    public class Person : EntityItem {
        override public int Id { get; set; } = 0;
        override public string Name { get; set; } = "";
        public City City { get; set; } = null!;
        public int CityId { get; set; }
        public string Phone { get; set; } = "";
        public List<Language> Languages { get; set; } = new();
    }
}
