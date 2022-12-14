using Asp.NetCoreIntro.Models;
using Asp.NetCoreIntro.Repository;
using Asp.NetCoreIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreIntro.Controllers
{
    public class TutorialController : Controller
         
        

    {
        private readonly ITutorialRepository _tutorialRepository;

        public TutorialController(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }
        public IActionResult Index()
        {

            
            //var tutorials = new TutorialRepository().GetAll();
            
            var tutorials = _tutorialRepository.GetAll();

                
            return View(tutorials);

    
        }
        [HttpGet]
        public IActionResult CreateTutorial()
        {


            return View();


        }
        [HttpPost]
        public IActionResult CreateTutorial(Tutorial tutorial)
        {
            Tutorial newTutorial = _tutorialRepository.Add(tutorial);

            return RedirectToAction("Index");


        }

        // update

        [HttpGet]
        public IActionResult EditTutorial(int id)
        {

            Tutorial tutorial = _tutorialRepository.GetTutorial(id);
            return View(tutorial);


        }
        [HttpPost]
        public IActionResult EditTutorial(Tutorial modifiedData)
        {
            Tutorial tutorial = _tutorialRepository.GetTutorial(modifiedData.Id);
            tutorial.Name= modifiedData.Name;
            tutorial.Description= modifiedData.Description;
            Tutorial updatedTutorial = _tutorialRepository.Update(tutorial); 

            return RedirectToAction("Index");


        }


        public IActionResult DeleteTutorial(int Id)
        {
            Tutorial deletedTutorial = _tutorialRepository.Delete(Id);

            return RedirectToAction("Index");


        }

    }
}
