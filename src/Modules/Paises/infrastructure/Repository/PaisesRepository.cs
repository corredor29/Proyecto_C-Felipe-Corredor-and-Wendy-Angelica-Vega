using System;
using Microsoft.EntityFrameworkCore;
using Gestion_vuelos.src.Shared.Context;
using Gestion_vuelos.src.Modules.Paises.infrastructure.Entity;
namespace Gestion_vuelos.src.Modules.Paises.infrastructure.Repository;

    public class PaisesRepository
    {
        private readonly AppDbContext _context;

        public PaisesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaisesEntity>> GetAllAsync()
            => await _context.Paises.ToListAsync();

        public async Task<PaisesEntity?> GetByIdAsync(Guid id)
            => await _context.Paises.FindAsync(id);

        public async Task AddAsync(PaisesEntity entity)
        {
            await _context.Paises.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PaisesEntity entity)
        {
            _context.Paises.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Paises.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }

