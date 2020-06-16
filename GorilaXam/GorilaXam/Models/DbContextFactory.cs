using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GorilaXam.Models
{
    public class DbContextFactory :IDesignTimeDbContextFactory<LibraryDbContext>
    {
        public LibraryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryDbContext>();
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog=GorilaXam; Trusted_Connection=True; MultipleActiveResultSets=True");
            //optionsBuilder.UseSqlServer("Data Source=localhost;Database=GorilaXam;Integrated Security=True;");
            //test

            return new LibraryDbContext(optionsBuilder.Options);
        }
           
    }
}
