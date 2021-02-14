using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OverTheTopTournament.Models
{
    public partial class ContestantDbContext : DbContext
    {
        
            public ContestantDbContext()
            {
            }

            public ContestantDbContext(DbContextOptions<ContestantDbContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Contestant> FirstName { get; set; }
            public virtual DbSet<Contestant> LastName { get; set; }

           

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Contestant>(entity =>
                {
                    entity.Property(e => e.FirstName).HasColumnType("First Name");
                    entity.Property(e => e.LastName).HasColumnType("Last Name");
                });
                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
}
