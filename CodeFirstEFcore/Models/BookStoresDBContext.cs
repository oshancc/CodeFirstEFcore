using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEFcore.Models
{
    public class BookStoresDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
           optionsBuilder.UseSqlServer(@"Data Source=THELA;Initial Catalog=CodeFirstQuadrate;Integrated Security=True");
        }

        public DbSet<Publisher> Publishers { get; set; }
    }
}
