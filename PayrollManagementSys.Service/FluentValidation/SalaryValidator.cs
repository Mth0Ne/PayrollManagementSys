using FluentValidation;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.FluentValidation
{
    public class SalaryValidator: AbstractValidator<Salary>
    {
        public SalaryValidator()
        {
            RuleFor(x=>x.SalaryCoefficient)
                .NotEmpty().WithMessage("Maaş katsayısı boş geçilemez!")
                .NotNull()
                .WithName("Maaş Katsayısı");

            RuleFor(x => x.TaxDeduction)
                .NotEmpty().WithMessage("Vergi kesintisi boş geçilemez!")
                .NotNull()
                .WithName("Vergi Kesintisi");

            RuleFor(x => x.SgkDeduction)
                .NotEmpty().WithMessage("SGK kesintisi boş geçilemez!")
                .NotNull()
                .WithName("SGK Kesintisi");
        }
    }
}
