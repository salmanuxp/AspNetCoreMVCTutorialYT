using Asp.NetCoreIntro.Models;

namespace Asp.NetCoreIntro.Repository
{
    public interface ITutorialRepository
    {

        Tutorial Add(Tutorial tutorial);

        Tutorial Update (Tutorial modifiedTutorial);

        Tutorial Delete(int Id); 

        Tutorial GetTutorial(int Id);    

        IEnumerable<Tutorial> GetAll();
    }
}
