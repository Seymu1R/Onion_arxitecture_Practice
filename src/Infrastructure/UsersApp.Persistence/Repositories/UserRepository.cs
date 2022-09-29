using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;

namespace UsersApp.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>,IUser
    {       
        
        public UserRepository(ApplicationDBContext context) : base(context)
        {
            
        }
       
        
    }
}
