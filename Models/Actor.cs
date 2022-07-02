using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name="Profile URL")]
        public string ImageURL { get; set; }
        [Display(Name = "Actor Name")]
        public string Name { get; set; }

        [Display(Name = "Actor Bio")]
        public string Bio { get; set; }
        // one to many relationship Movies through Movies_Actor class

        public List<Movies_Actor> Movies_Actor { get; set; }
    }
}
