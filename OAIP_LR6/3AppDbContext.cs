using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OAIP_LR6;

public class AppDbContext : DbContext
{
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BOBBUILDER;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Engineer>()
            .HasMany(e => e.Projects)
            .WithOne(p => p.Engineer)
            .HasForeignKey(p => p.EngineerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
