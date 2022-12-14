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
            throw new NotImplementedException();
        }

        public Tutorial Update(Tutorial tutorial) {
            throw new NotImplementedException();
        }

        public Tutorial Delete(Tutorial tutorial) {
            throw new NotImplementedException();
        }

        public Tutorial GetTutorial(Tutorial tutorial) {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAll() {
            return _context.Tutorials;
        }

    }
}
