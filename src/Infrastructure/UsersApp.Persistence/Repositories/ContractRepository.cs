using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;

namespace UsersApp.Persistence.Repositories
{
    public class ContractRepository : GenericRepository<ConTract>,IContract
    {
        private ApplicationDBContext _context1;

        public ContractRepository(ApplicationDBContext context , ApplicationDBContext context1) : base(context)
        {
            _context1 = context1;
        }
        public async Task<List<ConTract>> GetAllContractByid(int id)
        {
            List<ConTract> conTracts = await _context1.ConTracts.Where(c => c.UserId == id).ToListAsync();
            return conTracts;
            
        }
    }
}
