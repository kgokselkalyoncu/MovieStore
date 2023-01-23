using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Models;
using MovieStore.Dto.Abstract;
using MovieStore.Dto.Repositories;

namespace MovieStore.Dto.EntityFramework
{
    public class EfMovieGenreRepository : GenericRepository<MovieGenre, DbContext>, IMovieGenreDal
    {
        private DbContext _db;
        public EfMovieGenreRepository(DbContext context) : base(context)
        {
            _db = context;
        }
    }
}