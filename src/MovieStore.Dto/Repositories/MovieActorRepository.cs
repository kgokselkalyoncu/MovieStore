using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Models;

namespace MovieStore.Dto.Repositories
{
    public class MovieActorRepository: GenericRepository<MovieActor, DbContext>
    {
        public MovieActorRepository(DbContext context) : base(context)
        {
        }
    }
}