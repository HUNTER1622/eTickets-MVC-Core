using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorServices
    {
        List<Actor> GetAllActor();
        Actor GetActorById(int Id);
        int AddActor(Actor model);
        bool UpdatActor(int Id, Actor model);
        bool DeleteActor(int Id);
    }
}
