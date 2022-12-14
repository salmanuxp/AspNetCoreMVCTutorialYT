using Asp.NetCoreIntro.Models;

namespace Asp.NetCoreIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private List<Tutorial> _tutorials;
        public TutorialRepository() {


             _tutorials = new List<Tutorial>
               {
                   new Tutorial { Id = 1, Name = "C#", Description = "C# Tutorial"},
                   new Tutorial { Id = 2, Name = "Asp.Net Core" , Description = "Asp.Net Core Tutorial"}
                };


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
            return _tutorials;
        }

    }
}
