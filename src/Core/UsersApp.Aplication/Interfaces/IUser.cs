using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Interfaces
{
    public interface IUser:IGenericRepository<User>
    {
        
    }
}
