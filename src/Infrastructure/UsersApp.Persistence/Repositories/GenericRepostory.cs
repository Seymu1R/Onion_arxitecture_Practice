using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain;
using UsersApp.Domain.Entities;
using System.Collections;

namespace UsersApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private ApplicationDBContext _context;
        public GenericRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateItemAsync(T item)
        {
            await _context.AddAsync(item);
            return await SuccessingAsync();
        }

        public async Task<bool> DeleteItembyIDAsync(int id)
        {
            T item = await _context.Set<T>().FindAsync(id);
            if(item is null) return false;
            _context.Set<T>().Remove(item);            
            return await SuccessingAsync();
        }

        public async Task<IEnumerable<T>> GetActiceItemAsync()
        {
            List<T> items = await _context.Set<T>().Where(x => x.State == 1).ToListAsync();
            return items;
        }

        public async Task<IEnumerable<T>> GetAllItemAsync()
        {
            List<T> MyList = await _context.Set<T>().ToListAsync();
            return MyList;
        }

        public async Task<T> GetItembyIdAsync(int id)
        {
            T item = await _context.Set<T>().FindAsync(id);
            return item;
        }      

        public async Task<bool> SuccessingAsync()
        {
            bool Success= await  _context.SaveChangesAsync() >= 0 ? true : false;
            return Success;
        }

        public async Task<T> UpdateItemAsync(int id )
        {
           T item = await _context.Set<T>().FindAsync(id);
            
            return item;
        }
    }
}
