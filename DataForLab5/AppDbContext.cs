using DataForLab5.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataForLab5
{
    public class AppDbContext: DbContext
    {
        private string Path { get; set; }
        public DbSet<ContactEntity> ContactEntities { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Path = System.IO.Path.Join(path, "contacts.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { ContactId = 1, Name = "Adam", Email = "adam@wsei.pl", Phone = "123123123", Birth = DateTime.Parse("2002,12,12") },
                new ContactEntity() { ContactId = 2, Name = "Maciek", Email = "maciek@wsei.pl", Phone = "345345345", Birth = DateTime.Parse("2002,04,25") },
                new ContactEntity() { ContactId = 3, Name = "Bartosz", Email = "bartosz@wsei.pl", Phone = "345234123", Birth = DateTime.Parse("2002,05,13") }
                );
        }
    }
}
