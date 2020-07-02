using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingDotNetCoreMVC.Models
{
    public class MyProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=database/myDB.db");
        }

        public DbSet<MovieModel> Movie { get; set; }
    }

}
