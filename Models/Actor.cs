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
        [Required(ErrorMessage ="Please enter ImageURL")]
        public string ImageURL { get; set; }
        [Display(Name = "Actor Name")]
        [Required(ErrorMessage ="Please enter Name")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Name should be graeter then 3 words")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Bio")]
        [Display(Name = "Actor Bio")]
        public string Bio { get; set; }
        // one to many relationship Movies through Movies_Actor class

        public List<Movies_Actor> Movies_Actor { get; set; }
    }
}
