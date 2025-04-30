using App_multas.Contexto;
using App_multas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace App_multas.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly ContextoBD _context;
        public VeiculosController(ContextoBD context)
        {
            _context = context;
        }
        
        public async Task<List<Veiculos>> ListaDeVeiculos()
        {
            var veiculos = await _context.Veiculos.Include(x => x.Multas). ToListAsync();
            return veiculos;
        }

        public async Task<Veiculos> GetVeiculos(string placa)
        {
            var veiculo = await _context.Veiculos.Include(m => m.Multas).Where(v => v.Placa==placa).FirstOrDefaultAsync();
            return veiculo;
        }

 
        public async Task Add(Veiculos veiculos)
        {
            await _context.Veiculos.AddAsync(veiculos);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}
