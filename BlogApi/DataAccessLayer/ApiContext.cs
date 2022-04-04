using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAccessLayer
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=BlokApiContextDb; integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
