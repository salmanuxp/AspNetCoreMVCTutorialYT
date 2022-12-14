using Asp.NetCoreIntro.Models;

namespace Asp.NetCoreIntro.Repository
{
    public interface ITutorialRepository
    {

        Tutorial Add(Tutorial tutorial);

        Tutorial Update (Tutorial tutorial);

        Tutorial Delete(Tutorial tutorial); 

        Tutorial GetTutorial(Tutorial tutorial);    

        IEnumerable<Tutorial> GetAll();
    }
}
