using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace ClearlyMovie.Data
{
    public class ClearlyMovieContext : DbContext
    {

        /// <summary>
        /// With EF Core, data access is performed using a model. A model is made up of entity classes and a context object that represents a session with the database. The context object allows querying and saving data. The database context is derived from Microsoft.EntityFrameworkCore.DbContext and specifies the entities to include in the data model.
        /// </summary>
        /// <param name="options"></param>
        public ClearlyMovieContext (DbContextOptions<ClearlyMovieContext> options)
            : base(options)
        {
        }

        //The preceding code creates a DbSet<Movie> property that represents the movies in the database.
        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
