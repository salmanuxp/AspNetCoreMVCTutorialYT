using Asp.NetCoreIntro.Context;
using Asp.NetCoreIntro.Models;

namespace Asp.NetCoreIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        //private List<Tutorial> _tutorials;

        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context) {

                _context= context;


        }
        public Tutorial Add(Tutorial tutorial)
        {
            _context.Tutorials.Add(tutorial);
            _context.SaveChanges();
            return tutorial;
        }

        public Tutorial Update(Tutorial tutorialModified) {
            _context.Update(tutorialModified);
            _context.SaveChanges();
            return tutorialModified;
        }
          
        public Tutorial Delete(int Id) {
            Tutorial tutorial = _context.Tutorials.Find(Id);
            if (tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
               
            }
            return tutorial;
        }

        public Tutorial GetTutorial(int Id) { 
            return _context.Tutorials.Find(Id);
        }

        public IEnumerable<Tutorial> GetAll() {
            return _context.Tutorials;
        }

    }
}
