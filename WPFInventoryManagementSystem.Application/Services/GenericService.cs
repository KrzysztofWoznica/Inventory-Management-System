using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WPFInventoryManagementSystem.Application.ServiceInterfaces;
using WPFInventoryManagementSystem.Data;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Application.Services
{
    public class GenericService<T> : IGenericService<T> where T : EntityBase
    {
        protected readonly InventoryContextFactory _contextFactory;

        public GenericService(InventoryContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using(InventoryContext context = _contextFactory.CreateDbContext())
            {
                var createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<IEnumerable> GetAll()
        {
            using (InventoryContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();

                return entities;
            }
        }

        public async Task<T> GetById(int id)
        {
            using (InventoryContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);

                return entity;
            }
        }

        public async Task<T> Modify(T entity)
        {
            using (InventoryContext context = _contextFactory.CreateDbContext())
            {                
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<bool> Remove(int id)
        {
            using (InventoryContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}
