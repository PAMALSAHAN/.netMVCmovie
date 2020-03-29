using Microsoft.EntityFrameworkCore;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCmovie.Models.Data
{
    public class MvcMovieContext :DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> db) :base(db)  //maka tama dependancy injection eka constructor eka hadala tiyanawa
        {
                
        }

        public DbSet<Movie> MovieTbl { get; set; } // mathanin thamai db eka hadanne Movie model eka anuwa
    }
}
