using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suciu_Bogdan_Lab8.Models;

namespace Suciu_Bogdan_Lab8.Data
{
    public class Suciu_Bogdan_Lab8Context : DbContext
    {
        public Suciu_Bogdan_Lab8Context (DbContextOptions<Suciu_Bogdan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Suciu_Bogdan_Lab8.Models.Book> Book { get; set; }
    }
}
