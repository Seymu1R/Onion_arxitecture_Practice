using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Dtos;
using UsersApp.Aplication.Wrappers;

namespace UsersApp.Aplication.Features.Queries.GetUsers.GetProductById
{
    public class GetUserByIdQuery:IRequest<ServiceResponse<GetUserByIdQueryViewDto>>
    {
        public int Id { get; set; }
    }
}
