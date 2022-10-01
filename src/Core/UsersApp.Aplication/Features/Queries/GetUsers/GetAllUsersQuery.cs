using MediatR;
using UsersApp.Aplication.Dtos;
using System.Collections.Generic;
using UsersApp.Aplication.Interfaces;
using System.Xml.Linq;
using AutoMapper;
using UsersApp.Aplication.Wrappers;

namespace UsersApp.Aplication.Features.Queries.GetUsers
{
    public class GetAllUsersQuery : IRequest<ServiceResponse<List<UserViewDto>>>
    {
        public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, ServiceResponse<List<UserViewDto>>>
        {
            private IUser _userrepostories;
            private IMapper _mapper;

            public GetAllUsersQueryHandler(IUser userrepostories, IMapper mapper)
            {
                _userrepostories = userrepostories;
                _mapper = mapper;
            }
            public async Task<ServiceResponse<List<UserViewDto>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                var useRs = await _userrepostories.GetAllItemAsync();
                var viewModel = _mapper.Map<List<UserViewDto>>(useRs);

                return new ServiceResponse<List<UserViewDto>>(viewModel);

            }

        }  
    }
}
