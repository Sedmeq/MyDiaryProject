using Microsoft.EntityFrameworkCore;
using MySecondProject.Models;
using System.Diagnostics.Tracing;

namespace MySecondProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {
            
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}
