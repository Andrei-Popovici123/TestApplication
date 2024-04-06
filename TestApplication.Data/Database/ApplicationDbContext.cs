using Microsoft.EntityFrameworkCore;
using TestApplication.Data.Entities;

namespace TestApplication.Data.Database;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
}