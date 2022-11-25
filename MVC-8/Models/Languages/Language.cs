namespace MVC_8.Models {
    public class Language : EntityItem {
        override public int Id { get; set; } = 0;
        override public string Name { get; set; } = "";
        public List<Person> People { get; set; } = new();
    }
}
