using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.Dto.Abstract;
using MovieStore.Data;

namespace MovieStore.Dto.Repositories
{
    public class GenericRepository<T, TContext> : IGenericDal<T> where T : class where TContext : DbContext
    {
        private readonly TContext context;
        public GenericRepository(TContext context)
        {
            this.context = context;
        }

        public void Delete(T entity)
        {
            //using var c = new PhoneBookDbContext();
            //c.Remove(entity);
            this.context.Update(entity);
            this.context.SaveChanges();
            
        }

        public List<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            this.context.Add(entity);
            this.context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.context.Update(entity);
            this.context.SaveChanges();
        }
    }
}