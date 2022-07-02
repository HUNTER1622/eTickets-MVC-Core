using eTickets.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Display(Name="Movie Name")]
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships

        public List<Movies_Actor>   Movies_Actor { get; set; }

        // Relationship with Cinema
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        // Relationship with Producer
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }

    }
}
