using Asp.NetCoreIntro.Models;

using Asp.NetCoreIntro.ViewModels;
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




            return View(tutorials);

    
        }
    }
}
