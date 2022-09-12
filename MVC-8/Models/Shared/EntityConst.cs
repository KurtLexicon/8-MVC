using System.Drawing;

namespace MVC_8.Models.Home {
    public class EntityConst {
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public string Names { get; set; } = "";
        public Color Color = Color.FromArgb(128, 128, 128);
        public bool CanCreateRandom { get; set; } = false;
    };
}

