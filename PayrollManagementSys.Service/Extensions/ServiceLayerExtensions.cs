using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.FluentValidation;
using PayrollManagementSys.Service.Helpers;
using PayrollManagementSys.Service.Services.Abstract;
using PayrollManagementSys.Service.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Extensions
{
    public  static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmanService, DepartmanService>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IPayrollService, PayrollService>();
            services.AddScoped<IDashboardService,DashboardService>();

            services.AddScoped<IPdfHelper, PdfHelper>();




            services.AddAutoMapper(assembly);


            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<DepartmanValidator>();
                opt.RegisterValidatorsFromAssemblyContaining<EmployeeValidator>();
                opt.RegisterValidatorsFromAssemblyContaining<EmployeeUpdateValidator>();
                opt.RegisterValidatorsFromAssemblyContaining<Salary>();
                opt.RegisterValidatorsFromAssemblyContaining<AppRole>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            });

            return services;
        }
    }
}
