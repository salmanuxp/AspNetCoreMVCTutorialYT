using Asp.NetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreIntro.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            var tutorials = new List<Tutorial>
            {
                new Tutorial { Id = 1, Name = "C#", Description = "C# Tutorial"},
                new Tutorial { Id = 2, Name = "Asp.Net Core" , Description = "Asp.Net Core Tutorial"}
            };


            ViewData["tutorials"] = tutorials;

            return View();
        }
    }
}
