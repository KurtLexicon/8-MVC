using System.Drawing;

namespace MVC_8.Models {
    public static class Const {
        static public readonly EntityConst User = new() {
            Code = "Users",
            Name = "User",
            Names = "Users",
        };
        static public readonly EntityConst City = new() {
            Code = "Cities",
            Name = "City",
            Names = "Cities",
        };
        static public readonly EntityConst Country = new() {
            Code = "Countries",
            Name = "Country",
            Names = "Countries",
        };
        static public readonly EntityConst Person = new() {
            Code = "People",
            Name = "Person",
            Names = "People",
            CanCreateRandom = true
        };
        static public readonly EntityConst Language = new() {
            Code = "Languages",
            Name = "Language",
            Names = "Languages",
        };
    }
}
