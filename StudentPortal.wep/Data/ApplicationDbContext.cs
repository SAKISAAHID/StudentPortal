using StudentPortal.wep.Models.Entities;

namespace StudentPortal.wep.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<StudentModels> students { get; set; }

    }
}
