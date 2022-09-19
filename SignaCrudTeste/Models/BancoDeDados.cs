using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SignaCrudTeste.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-396C030;Initial Catalog=TesteSigna;Integrated Security=True");
        }
    }
}
    

