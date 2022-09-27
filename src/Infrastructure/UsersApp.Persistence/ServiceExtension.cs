using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;
using UsersApp.Persistence.Repositories;

namespace UsersApp.Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistanceVoid( this IServiceCollection serviceCollection, IConfiguration configuration) 
        {
            serviceCollection.AddDbContext<ApplicationDBContext>(x => x.UseSqlServer(configuration.GetConnectionString("UsersConnectionString")));
            serviceCollection.AddTransient<IUser,UserRepository>();
            serviceCollection.AddTransient<IContract, ContractRepository>();
        }
    }
}
