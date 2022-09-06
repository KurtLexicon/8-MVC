using System.Drawing;

namespace MVC_8.Models.Home {
    public static class Const {
        static public readonly EntityConst City = new() {
            Code = "City",
            Name = "City",
            Names = "Cities",
            View = "PvDetailCity",
            Color = Color.FromArgb(128, 128, 255)
        };
        static public readonly EntityConst Country = new () {
            Code = "Country",
            Name = "Country",
            Names = "Countries",
            View = "PvDetailCountry",
            Color = Color.FromArgb(255, 128, 128)
        };
        static public readonly EntityConst Person = new () {
            Code = "Person",
            Name = "Person",
            Names = "People",
            View = "PvDetailPerson",
            Color = Color.FromArgb(255, 128, 128),
            CanCreateRandom = true
        };
        static public readonly EntityConst Language = new () {
            Code = "Language",
            Name = "Language",
            Names = "Languages",
            View = "PvDetailLanguage",
            Color = Color.FromArgb(241, 241, 75)
        };
    }
}
