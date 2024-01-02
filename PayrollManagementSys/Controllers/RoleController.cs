using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;

namespace PayrollManagementSys.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IValidator<AppRole> validator;
        private readonly IRoleService roleService;

        public RoleController(IValidator<AppRole> validator,IRoleService roleService)
        {
            this.validator = validator;
            this.roleService = roleService;
        }
        [Authorize(Roles = "Superadmin,Admin")]
        [HttpPost]
        public async  Task<IActionResult> AddWithAjax([FromBody] AppRole role)
        {
            var result = await validator.ValidateAsync(role);
            if (result.IsValid)
            {
                await roleService.InsertRoleAsync(role);
                return Json(role.Name);
            }
            else
                return Json(result.Errors.First().ErrorMessage);
        }
    }
}
