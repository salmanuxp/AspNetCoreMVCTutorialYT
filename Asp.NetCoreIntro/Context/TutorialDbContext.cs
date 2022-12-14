using Asp.NetCoreIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreIntro.Context
{
    public class TutorialDbContext:DbContext 
        
    {
        public  TutorialDbContext(DbContextOptions<TutorialDbContext> options): base
            (options) {
        }
        public DbSet<Tutorial> Tutorials { get; set; }  

    }
}
