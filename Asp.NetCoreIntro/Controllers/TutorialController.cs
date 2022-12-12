using Asp.NetCoreIntro.Models;

using Asp.NetCoreIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreIntro.Controllers
{
    public class TutorialController : Controller
         
 

    {
        [ViewData]
        public string title { get; set; }
        public IActionResult Index()
        {


            //var tutorials = new List<Tutorial>
            //    {
            //        new Tutorial { Id = 1, Name = "C#", Description = "C# Tutorial"},
            //        new Tutorial { Id = 2, Name = "Asp.Net Core" , Description = "Asp.Net Core Tutorial"}
            //    };

            //    title = "Tutorial List";
            //    //ViewData["tutorials"] = tutorials;

            //    ViewBag.Tutorials = tutorials;
            //    ViewData["name"] = "All about .Net...";


            var newModel = new TutorialViewModel
            {

                tutorial = new Tutorial
                {
                    Id = 1,
                    Name = "Name",
                    Description = "Desc"

                },

                title = "new title ",
            };


            //return View();
            return View(newModel);
        }
    }
}
