using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movies_Actor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie  { get; set; }
    }
}
