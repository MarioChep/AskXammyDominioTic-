using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GorilaXam.Models
{
    public class Book
    {
        [Key]
        public int Id_Book { get; set; }
        [Column("Id_Author")]
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Section { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }

        public Author Author { get; set; }


    }
}
