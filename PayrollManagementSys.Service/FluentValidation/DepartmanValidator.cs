using FluentValidation;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.FluentValidation
{
    public class DepartmanValidator: AbstractValidator<Departman>
    {
        public DepartmanValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Departman adı boş geçilemez!")
                .NotNull()
                .MinimumLength(3).WithMessage("Departman adı minimum 3 karakterden oluşmalı!")
                .MaximumLength(50).WithMessage("Departman adı maximum 50 karakterden oluşmalı!")
                .WithName("Departman Adı");
        }
    }
}
