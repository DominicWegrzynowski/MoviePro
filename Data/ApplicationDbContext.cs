using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviePro.Models.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Collection> Collection { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieCollection> MovieCollection { get; set; }

    }
}
