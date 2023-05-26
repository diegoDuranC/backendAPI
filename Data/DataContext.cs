using Microsoft.EntityFrameworkCore;
using persona_api.Models;

namespace persona_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
