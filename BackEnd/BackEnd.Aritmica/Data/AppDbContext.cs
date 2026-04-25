using BackEnd.Aritmica.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Aritmica.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
    }
}
