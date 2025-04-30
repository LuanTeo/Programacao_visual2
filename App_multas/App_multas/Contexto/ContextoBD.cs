using App_multas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace App_multas.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {
        }
        public DbSet<Veiculos> Veiculos { get; set; }
        public DbSet<Multa> Multas { get; set; }       
    }
}

