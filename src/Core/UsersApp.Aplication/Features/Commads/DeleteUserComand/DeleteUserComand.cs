using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UsersApp.Aplication.Features.Commads.DeleteUserComand.DeleteUserComand;
using UsersApp.Aplication.Interfaces;
using UsersApp.Aplication.Wrappers;

namespace UsersApp.Aplication.Features.Commads.DeleteUserComand
{
    public class DeleteUserComand : IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }        
    }
}
