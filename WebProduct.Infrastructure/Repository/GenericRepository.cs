﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebProduct.Core.Entities;
using WebProduct.Core.Interface;
using WebProduct.Infrastructure.Data;

namespace WebProduct.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BasicEntity<int>
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T Entity)
        {
            await _context.Set<T>().AddAsync(Entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll()

         => _context.Set<T>().AsNoTracking().ToList();


        public async Task<IReadOnlyList<T>> GetAllAsync()
        => await _context.Set<T>().AsNoTracking().ToListAsync();
        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().AsQueryable();
            foreach (var item in includes)
            {
                query = query.Include(item);

            }
            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
     => await _context.Set<T>().FindAsync(id);

        public async Task<T> GetByidAsync(int id, params Expression<Func<T, object>>[] includes)
        {
            //  IQueryable<T> query = _context.Set<T>();
            IQueryable<T> query = _context.Set<T>().Where(x => x.Id == id);
            foreach (var item in includes)
            {
                query = query.Include(item);

            }
            return await query.FirstOrDefaultAsync();
            //  return await ((DbSet<T>)query).FindAsync();

        }

        public async Task UpdateAsync(int id, T Entity)
        {
            var ex_entity = await _context.Set<T>().FindAsync(id);
            if (ex_entity != null)
            {
                _context.Update(ex_entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountAsync()
         => await _context.Set<T>().CountAsync();
    }
}
