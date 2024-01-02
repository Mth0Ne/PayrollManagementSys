using FluentValidation;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.FluentValidation
{
    public class RoleValidator: AbstractValidator<AppRole>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull().WithMessage("Role adı boş geçilemez")
                .MinimumLength(3).WithMessage("Minimum rol adı 3 karakterden oluşmalı")
                .WithName("Kategori Adı");
        }
    }
}
