using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Bussines.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Add(T model);
        void Delete(T model);
        void Update(T model);
        List<T> GetList();
        T? GetById(int id);
    }
}