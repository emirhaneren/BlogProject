using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAccesLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //server location; DB name; security
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DbCoreBlogApi;integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
