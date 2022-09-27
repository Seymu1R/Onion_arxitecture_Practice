using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;

namespace UsersApp.Persistence.Repositories
{
    public class ContractRepository : GenericRepository<ConTract>,IContract
    {
        public ContractRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
