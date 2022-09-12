using System.Drawing;

namespace MVC_8.Models.Home {
    public static class Const {
        static public readonly EntityConst User = new() {
            Code = "Users",
            Name = "User",
            Names = "Users",
            Color = Color.FromArgb(255, 255, 192)
        };
        static public readonly EntityConst City = new() {
            Code = "Cities",
            Name = "City",
            Names = "Cities",
            Color = Color.FromArgb(128, 128, 255)
        };
        static public readonly EntityConst Country = new() {
            Code = "Countries",
            Name = "Country",
            Names = "Countries",
            Color = Color.FromArgb(255, 128, 128)
        };
        static public readonly EntityConst Person = new() {
            Code = "People",
            Name = "Person",
            Names = "People",
            Color = Color.FromArgb(255, 128, 128),
            CanCreateRandom = true
        };
        static public readonly EntityConst Language = new() {
            Code = "Languages",
            Name = "Language",
            Names = "Languages",
            Color = Color.FromArgb(241, 241, 75)
        };
    }
}
