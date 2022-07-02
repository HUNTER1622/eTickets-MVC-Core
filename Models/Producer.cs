using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name="Profile Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Producer Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Bio { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
