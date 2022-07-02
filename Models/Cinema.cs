using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name ="Profile Picture")]
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
