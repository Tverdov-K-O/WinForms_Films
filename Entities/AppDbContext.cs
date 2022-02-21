using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Films.Data;

namespace WinForms_Films.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Film>()
                .Property(s => s.CreatedAt)
                .HasDefaultValueSql("getDate()");
            modelBuilder.Entity<Genre>()
                .Property(s => s.CreatedAt)
                .HasDefaultValueSql("getDate()");

            modelBuilder.Entity<Film>()
                .Property(s => s.Id)
                .HasDefaultValueSql("newid()");
            modelBuilder.Entity<Genre>()
                .Property(s => s.Id)
                .HasDefaultValueSql("newid()");

            modelBuilder.Entity<Film>()
                .HasMany(f => f.Genres)
                .WithMany(g => g.Films)
                .UsingEntity(j => j.ToTable("Pivot_FilmGenre"));
            //
            modelBuilder.Entity<Genre>()
               .HasMany(f => f.Films)
               .WithMany(g => g.Genres)
               .UsingEntity(j => j.ToTable("Pivot_FilmGenre"));
            //
        }
        string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tverd\source\repos\WinForms_Films\DBFiles\DBFilms.mdf;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(sqlConnectionString);

        }
    }
}
