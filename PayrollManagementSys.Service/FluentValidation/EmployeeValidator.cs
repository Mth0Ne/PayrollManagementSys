using FluentValidation;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<AppUser>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Çalışan adı boş geçilemez")
                .NotNull()
                .WithName("Ad");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Çalışan soyadı boş geçilemez")
                .NotNull()
                .WithName("Soyad");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Çalışan email boş geçilemez")
                .NotNull()
                .WithName("Email");

            RuleFor(x => x.PasswordHash)
                .NotEmpty().WithMessage("Çalışan şifre boş geçilemez")
                .NotNull()
                .WithName("Şifre");

            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Çalışan kullanıcı adı boş geçilemez")
                .NotNull()
                .WithName("Kullanıcı adı");

            RuleFor(x => x.BirtDate)
                .NotEmpty().WithMessage("Çalışan doğum tarihi boş geçilemez")
                .NotNull()
                .WithName("Doğum tarihi");

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Çalışan cinsiyeti boş geçilemez")
                .NotNull()
                .WithName("Cinsiyet");

            RuleFor(x => x.Addres)
                .NotEmpty().WithMessage("Çalışan adresi boş geçilemez")
                .NotNull()
                .WithName("Adres");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Çalışan telefon numarası boş geçilemez")
                .NotNull()
                .WithName("Telefon Numarası");

            RuleFor(x => x.SGKNumara)
                .NotEmpty().WithMessage("Çalışan SGK numarası boş geçilemez")
                .NotNull()
                .WithName("SGK Numarası");
        }
    }
}
