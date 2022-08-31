using Microsoft.EntityFrameworkCore;

namespace CursoApiRestfull.Model.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options): base(options)
        {
         
        }
        public DbSet<Person> Persons { get; set; }
    }
}
