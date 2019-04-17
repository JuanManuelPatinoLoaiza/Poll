
namespace Poll.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Poll.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
