using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Aplication.Wrappers;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Features.Commads.UpdateUserComand
{
    public class UpdateUserComand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
    }
}
