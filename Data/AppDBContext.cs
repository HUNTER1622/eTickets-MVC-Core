using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies_Actor>().HasKey(am => new { am.MovieId,am.ActorId});
            modelBuilder.Entity<Movies_Actor>().HasOne(m => m.Movie).WithMany(am => am.Movies_Actor).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Movies_Actor>().HasOne(m => m.Actor).WithMany(am => am.Movies_Actor).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Movies_Actor> Movies_Actors { get; set; }

    }
}
