using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab12_MVC_Part_2.Models
{
    public class Lab12_MVC_Part_2Context : DbContext
    {
        public Lab12_MVC_Part_2Context (DbContextOptions<Lab12_MVC_Part_2Context> options)
            : base(options)
        {
        }

        public DbSet<Lab12_MVC_Part_2.Models.Movie> Movie { get; set; }
    }
}
