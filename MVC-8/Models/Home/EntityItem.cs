
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Data;
using MVC_8.Models.ViewModels;
using System.Drawing;

namespace MVC_8.Models.Home {
    abstract public class EntityItem {
        abstract public int Id { get; set; }
        abstract public string Name { get; set; }   
    }
}
