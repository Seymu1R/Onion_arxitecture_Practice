using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Validation
{
    public class ContractValidation : AbstractValidator<ConTract>
    {
        public ContractValidation()
        {
            RuleFor(c => c.Title).NotNull().NotEmpty();
            RuleFor(c => c.Description).NotNull().NotEmpty();
            RuleFor(c => c.UserId).NotEmpty().NotNull();

        }

        
    }
}
