using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GorilaXam.Models;

namespace GorilaXam.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> data)
            : base(data) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog=GorilaXam; Trusted_Connection=True; MultipleActiveResultSets=True");
            //optionsBuilder.UseSqlServer("Data Source=localhost;Database=GorilaXam;Integrated Security=True;");
        }
    }
}
