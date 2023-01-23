using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Bussines.Abstract;
using MovieStore.Dto.Abstract;
using MovieStore.Data.Models;

namespace MovieStore.Bussines.Concrete
{
    public class MovieGenreManager : IMovieGenreService
    {
        IMovieGenreDal _movieGenreDal;
        
        public MovieGenreManager(IMovieGenreDal movieGenreDal)
        {
            _movieGenreDal = movieGenreDal;
        }

        public void Add(MovieGenre model)
        {
            _movieGenreDal.Insert(model);
        }

        public void Delete(MovieGenre model)
        {
            model.IsDeleted = true;
            model.Deleted = DateTime.Now;
            _movieGenreDal.Delete(model);
        }

        public void Update(MovieGenre model)
        {
            model.Updated = DateTime.Now;
            _movieGenreDal.Update(model);
        }

        public MovieGenre? GetById(int id)
        {
            return _movieGenreDal.GetById(id);
        }

        public List<MovieGenre> GetList()
        {
            return _movieGenreDal.GetAll().Where(x => x.IsDeleted == false).ToList();
        }
    }
}