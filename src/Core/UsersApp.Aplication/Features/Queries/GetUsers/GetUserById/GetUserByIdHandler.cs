using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Dtos;
using UsersApp.Aplication.Interfaces;
using UsersApp.Aplication.Wrappers;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Features.Queries.GetUsers.GetProductById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, ServiceResponse<GetUserByIdQueryViewDto>>
    {
        private IUser _userrepos;
        private IMapper _mapper;

        public GetUserByIdHandler(IUser userrepos, IMapper mapper)
        {
            _userrepos = userrepos;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetUserByIdQueryViewDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userrepos.GetItembyIdAsync(request.Id);
            var dto = _mapper.Map<GetUserByIdQueryViewDto>(user);
            return new ServiceResponse<GetUserByIdQueryViewDto>(dto);
        }
    }
}
