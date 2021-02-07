using AXA_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AXA_Project.Helpers
{
    /// <summary>
    /// Project database context
    /// </summary>
	public class Context : DbContext
	{
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<RatingModel> Ratings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{           
            modelBuilder.Entity<RatingModel>().ToTable("Ratings");
        }
	}
}
