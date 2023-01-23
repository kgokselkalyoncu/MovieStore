using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Bussines.Concrete;
using MovieStore.Data.Data;
using MovieStore.Data.Models;
using MovieStore.Dto.EntityFramework;


namespace MovieStore.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieGenreController : ControllerBase
    {
        MovieGenreManager movieGenreManager = new MovieGenreManager(new EfMovieGenreRepository(new MovieStoreDbContext()));

        // GET: api/<ComInfoTypeController>
        [HttpGet]
        public List<MovieGenre> Get()
        {
            return movieGenreManager.GetList();
        }
    }
}