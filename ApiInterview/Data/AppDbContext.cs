using Microsoft.EntityFrameworkCore;
using ApiInterview.Model;

namespace ApiInterview.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Model.Task> Tasks { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
