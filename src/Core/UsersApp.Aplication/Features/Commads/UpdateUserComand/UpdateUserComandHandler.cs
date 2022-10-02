using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Interfaces;
using UsersApp.Aplication.Wrappers;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Features.Commads.UpdateUserComand
{
    public class UpdateUserComandHandler : IRequestHandler<UpdateUserComand, ServiceResponse<UpdateUserComandDto>>
    {
        private IMapper _mapper;
        private IUser _userrepository;

        public UpdateUserComandHandler(IUser userrepository,IMapper mapper)
        {
            _mapper = mapper;
            _userrepository = userrepository;
        }
        public async Task<ServiceResponse<UpdateUserComandDto>> Handle(UpdateUserComand request, CancellationToken cancellationToken)
        {     
            var userf = _userrepository.UpdateItemAsync(request.Id);
            var user = _mapper.Map<User>(userf);
            return await new ServiceResponse<UpdateUserComandDto>(user);
        }
    }
}
