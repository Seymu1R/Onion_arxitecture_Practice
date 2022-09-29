using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Aplication
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services) 
        {
            var asmb = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(asmb);
            services.AddMediatR(asmb);
        }
    }
}
