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
    public class UpdateUserComandHandler : IRequestHandler<UpdateUserComand, ServiceResponse<bool>>
    {
        private IMapper _mapper;
        private IUser _userrepository;

        public UpdateUserComandHandler(IUser userrepository,IMapper mapper)
        {
            _mapper = mapper;
            _userrepository = userrepository;
        }
        public async Task<ServiceResponse<bool>> Handle(UpdateUserComand request, CancellationToken cancellationToken)
        {
            var requestmap = _mapper.Map<User>(request);   
            var userf = await _userrepository.UpdateItemAsync(request.Id);
            userf.Age = requestmap.Age;
            userf.UserName = requestmap.UserName;
            userf.FatherName = requestmap.FatherName;
            userf.Name = requestmap.Name;
            userf.SurName=requestmap.SurName;
            bool sucess=  await  _userrepository.SuccessingAsync();
            if (!sucess) return new ServiceResponse<bool>(!sucess);
            return new ServiceResponse<bool>(sucess);

        }
    }
}
