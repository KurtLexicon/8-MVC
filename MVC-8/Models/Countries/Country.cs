namespace MVC_8.Models.Home {
    public class Country : EntityItem {
        override public int Id { get; set; } = 0;
        override public string Name { get; set; } = "";
        public List<City> Cities { get; set; } = new();
    }
}
