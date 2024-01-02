using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PayrollManagementSys.Data.Migrations;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;

namespace PayrollManagementSys.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardService dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAvarageSalaryByDepartman()
        {
            List<AverageSalaryByDepartment> salaryByDepartman = await dashboardService.GetAverageSalaryByDepartmentsAsync();

            return Json(salaryByDepartman);
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalEmployee()
        {
            var count = await dashboardService.GetTotalEmployee();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalDepartman()
        {
            var count = await dashboardService.GetTotalDepartman();
            return Json(count);
        }
    }
}
