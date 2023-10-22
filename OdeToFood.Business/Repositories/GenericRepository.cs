using OdeToFood.Business.Services;
using OdeToFood.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Business.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected OdeToFoodDbContext context;
        public GenericRepository(OdeToFoodDbContext context)
        {
            this.context = context;  
        }

        public async Task Add(T entity)
        {
            context.Set<T>().Add(entity);   
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }


        public async Task Update(T entity)
        {
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            //context.Set<T>().AddOrUpdate(entity);
            await context.SaveChangesAsync();
        }
    }
}
