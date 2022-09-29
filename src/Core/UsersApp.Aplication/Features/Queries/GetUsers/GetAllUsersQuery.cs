using MediatR;
using UsersApp.Aplication.Dtos;
using System.Collections.Generic;
using UsersApp.Aplication.Interfaces;
using System.Xml.Linq;

namespace UsersApp.Aplication.Features.Queries.GetUsers
{
    public class GetAllUsersQuery : IRequest<List<UserViewDto>>
    {
        public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserViewDto>>
        {
            private IUser _userrepostories;

            public GetAllUsersQueryHandler(IUser userrepostories)
            {
                _userrepostories = userrepostories;
            }
            public async Task<List<UserViewDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                var users = await _userrepostories.GetAllItemAsync();
                
                return  users.Select(i => new UserViewDto
                {
                    Id = i.Id,
                    UserName = i.UserName,
                    Name = i.Name,
                    FathetName = i.FatherName,
                    Age = i.Age,
                    SurName = i.SurName
                }).ToList();

            }
        }
    }
}
