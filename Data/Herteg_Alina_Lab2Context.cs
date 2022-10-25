using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Herteg_Alina_Lab2.Models;

namespace Herteg_Alina_Lab2.Data
{
    public class Herteg_Alina_Lab2Context : DbContext
    {
        public Herteg_Alina_Lab2Context (DbContextOptions<Herteg_Alina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Herteg_Alina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Herteg_Alina_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
