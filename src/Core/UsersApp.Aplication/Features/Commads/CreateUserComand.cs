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

namespace UsersApp.Aplication.Features.Commads
{
    public class CreateUserComand:IRequest<ServiceResponse<int>>
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }

        public class CreateUserComandHandler : IRequestHandler<CreateUserComand, ServiceResponse<int>>
        {
            private IGenericRepository<User> _userrepostories;
            private IMapper _mapper;

            public CreateUserComandHandler(IUser userrepostories, IMapper mapper)
            {
                _userrepostories = userrepostories;
                _mapper = mapper;
            }
            public async Task<ServiceResponse<int>> Handle(CreateUserComand request, CancellationToken cancellationToken)
            {
                var user = _mapper.Map<User>(request);
                await _userrepostories.CreateItemAsync(user);                
                return new ServiceResponse<int>(user.Id);
            }
        }
    }
}
