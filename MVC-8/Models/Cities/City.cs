namespace MVC_8.Models {
    public class City : EntityItem {
        override public int Id { get; set; } = 0;
        override public string Name { get; set; } = "";
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public List<Person> People { get; set; } = new();
    }
}
