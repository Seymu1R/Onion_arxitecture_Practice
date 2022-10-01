using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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
