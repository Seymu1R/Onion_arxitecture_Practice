using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Interfaces
{
    public interface IGenericRepository<T> where T : BaseClass
    {
        Task<IEnumerable<T>> GetAllItemAsync();
        Task<IEnumerable<T>> GetActiceItemAsync();
        Task<T> GetItembyIdAsync(int id);
        Task<bool> DeleteItembyIDAsync(int id);
        Task<bool> CreateItemAsync(T item);
        Task<bool> UpdateItemAsync(int id );
    }
}
