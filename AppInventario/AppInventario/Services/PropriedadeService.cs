﻿using AppInventario.Contexto;
using AppInventario.Models;
using Microsoft.EntityFrameworkCore;

namespace AppInventario.Services
{
    public class PropriedadeService
    {
        private readonly ContextoBD _context;
        public PropriedadeService(ContextoBD con)
        {
            _context = con;
        }
        public async Task Add(List<Propriedade> bens)
        {
            if (bens == null)
            {
                await _context.Propriedades.AddRangeAsync(bens);
            }
        }
        public async Task Add(Propriedade bens)
        {
            if (bens != null)
            {
                await _context.Propriedades.AddRangeAsync(bens);
            }
        }
        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }

        // com include, o nome do dono da propriedade tambem sera carregado
        public async Task<List<Propriedade>> Propriedade()
        {
            var p= await _context.Propriedades.Include(p =>p.Pessoa).ToListAsync();
            return p;
        }
    }
}
