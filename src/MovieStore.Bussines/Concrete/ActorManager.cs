using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Bussines.Abstract;
using MovieStore.Dto.Abstract;
using MovieStore.Data.Models;

namespace MovieStore.Bussines.Concrete
{
    public class ActorManager : IActorService
    {
        IActorDal _actorDal;
        
        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        public void Add(Actor model)
        {
            _actorDal.Insert(model);
        }

        public void Delete(Actor model)
        {
            model.IsDeleted = true;
            model.Deleted = DateTime.Now;
            _actorDal.Delete(model);
        }

        public void Update(Actor model)
        {
            model.Updated = DateTime.Now;
            _actorDal.Update(model);
        }

        public Actor? GetById(int id)
        {
            return _actorDal.GetById(id);
        }

        public List<Actor> GetList()
        {
            return _actorDal.GetAll().Where(x => x.IsDeleted == false).ToList();
        }
    }
}