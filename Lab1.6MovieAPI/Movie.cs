using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1._6MovieAPI
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Runtime { get; set; }
    }
}
