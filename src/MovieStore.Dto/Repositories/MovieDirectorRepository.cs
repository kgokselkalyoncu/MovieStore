using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Models;

namespace MovieStore.Dto.Repositories
{
    public class MovieDirectorRepository: GenericRepository<MovieDirector, DbContext>
    {
        public MovieDirectorRepository(DbContext context) : base(context)
        {
        }
    }
}