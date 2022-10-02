using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Aplication.Wrappers;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Features.Commads.DeleteUserComand
{
    public class DeleteUserComandHandler : IRequestHandler<DeleteUserComand, ServiceResponse<bool>>
    {
        private IUser _userreposotiries;

        public DeleteUserComandHandler(IUser userreposotiries)
        {
            _userreposotiries = userreposotiries;
        }
        public async Task<ServiceResponse<bool>> Handle(DeleteUserComand request, CancellationToken cancellationToken)
        {
            bool success= await _userreposotiries.DeleteItembyIDAsync(request.Id);            
            if (!success)return new ServiceResponse<bool>(false);            
            return new ServiceResponse<bool>(success);
        }
    }
}
