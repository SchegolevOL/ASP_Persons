using Microsoft.EntityFrameworkCore;

namespace ASP_Persons.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
