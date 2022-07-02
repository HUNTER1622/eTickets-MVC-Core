using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorServices : IActorServices
    {
        private readonly AppDBContext db;
        public ActorServices(AppDBContext context)
        {
            db = context;
        }
        public bool AddActor(Actor model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteActor(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAllActor()
        {
            var list = db.Actors.Include(m => m.Movies_Actor).ToList();
            return list;
        }

        public bool UpdatActor(int Id, Actor model)
        {
            throw new NotImplementedException();
        }
    }
}
