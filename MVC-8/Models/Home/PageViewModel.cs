using System.Drawing;

namespace MVC_8.Models.Home {
    public class PageViewModel {
        public string Title { get; set; }
        public string EntityCode { get; set; }
        public Color Color { get; set; }
        public PageViewModel(string title, string entityCode, Color color) {
            Title = title;
            EntityCode = entityCode;
            Color = color;
        }
    }
}
