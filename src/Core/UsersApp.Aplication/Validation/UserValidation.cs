using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Validation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u=>u.Name).NotNull().NotEmpty();
            RuleFor(u => u.UserName).NotNull().NotEmpty();
            RuleFor(u => u.SurName).NotNull().NotEmpty();
            RuleFor(u => u.FatherName).NotNull().NotEmpty();
            RuleFor(u => u.Age).GreaterThan(0);
        }

    }
}
