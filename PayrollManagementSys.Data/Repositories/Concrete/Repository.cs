using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PayrollManagementSys.Data.Context;
using PayrollManagementSys.Data.Repositories.Abstract;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Data.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> table { get => dbContext.Set<T>(); }
        public async Task AddAsync(T entity)
        {
            await table.AddAsync(entity);
        }

        public Task<int> CountAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => table.Remove(entity));
        }

        public async Task<List<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = table;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = table;
            query = query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    query.Include(property);
                }
            }
            return await query.SingleAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => table.Update(entity));
            return entity;
        }
        public async Task DepartmanAddAsync(string departmanName)
        {
            var departmanNameParam = new SqlParameter("@Name", departmanName);
            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE InsertDepartman @Name", parameters: new[] { departmanNameParam });
        }
        public async Task DepartmanUpdateAsync(string departmanName, int departmanId)
        {
            var departmanNameParam = new SqlParameter("@Name", departmanName);
            var departmanIdParam = new SqlParameter("@Id", departmanId);
            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE UpdateDepartman @Id,@Name", parameters: new[] { departmanIdParam, departmanNameParam });

        }
        public async Task DepartmanSafeDelete(int departmanId)
        {

            var departmanIdParam = new SqlParameter("@Id", departmanId);
            var IsDeleted = new SqlParameter("@Deleted", 1);

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE sp_UpdateDepartmanIsDeleted @Id,@Deleted", parameters: new[] { departmanIdParam, IsDeleted });

        }
        public async Task EmployeeAddAsync(EmployeeAddDto employeeAddDto, string password)
        {
            var passwordParam = new SqlParameter("@Password", password);
            var firstNameParam = new SqlParameter("@FirstName", employeeAddDto.FirstName);
            var lastNameParam = new SqlParameter("@LastName", employeeAddDto.LastName);
            var genderParam = new SqlParameter("@Gender", employeeAddDto.Gender);
            var birthDateParam = new SqlParameter("@BirthDate", employeeAddDto.BirtDate);
            var departmanParam = new SqlParameter("@DepartmentId", SqlDbType.Int);
            departmanParam.Value = employeeAddDto.DepertmanId;
            var addressParam = new SqlParameter("@Address", employeeAddDto.Addres);
            var sgkNumParam = new SqlParameter("@SGKNumara", employeeAddDto.SGKNumara);
            var userNameParam = new SqlParameter("@UserName", employeeAddDto.UserName);
            var emailParam = new SqlParameter("@Email", employeeAddDto.Email);
            var phoneNumberParam = new SqlParameter("@PhoneNumber", employeeAddDto.PhoneNumber);
            var roleParam = new SqlParameter("@RoleId", SqlDbType.Int);
            roleParam.Value = employeeAddDto.RoleId;

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE InsertEmployee @FirstName,@LastName,@Gender,@DepartmentId,@Address,@BirthDate," +
                "@SGKNumara,@UserName,@Email,@PhoneNumber,@Password,@RoleId", parameters:
                new[] { firstNameParam, lastNameParam, genderParam, departmanParam, addressParam,
                    birthDateParam,  sgkNumParam, userNameParam, emailParam, phoneNumberParam, passwordParam,roleParam });

        }
        public async Task EmployeeUpdateAsync(EmployeeUpdateDto employeeUpdateDto)
        {
            var employeeIdParam = new SqlParameter("@UserId", SqlDbType.Int);
            employeeIdParam.Value = employeeUpdateDto.Id;
            var firstNameParam = new SqlParameter("@FirstName", employeeUpdateDto.FirstName);
            var lastNameParam = new SqlParameter("@LastName", employeeUpdateDto.LastName);
            var genderParam = new SqlParameter("@Gender", employeeUpdateDto.Gender);
            var departmanParam = new SqlParameter("@DepartmentId", SqlDbType.Int);
            departmanParam.Value = employeeUpdateDto.DepertmanId;
            var addressParam = new SqlParameter("@Address", employeeUpdateDto.Addres);
            var sgkNumParam = new SqlParameter("@SGKNumara", employeeUpdateDto.SGKNumara);
            var userNameParam = new SqlParameter("@UserName", employeeUpdateDto.UserName);
            var emailParam = new SqlParameter("@Email", employeeUpdateDto.Email);
            var phoneNumberParam = new SqlParameter("@PhoneNumber", employeeUpdateDto.PhoneNumber);
            var roleParam = new SqlParameter("@RoleId", SqlDbType.Int);
            roleParam.Value = employeeUpdateDto.RoleId;

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE UpdateUser @UserId, @FirstName,@LastName,@Gender,@DepartmentId,@Address,@Email," +
                "@PhoneNumber,@SGKNumara,@UserName,@RoleId", parameters:
                new[] {employeeIdParam, firstNameParam, lastNameParam, genderParam, departmanParam, addressParam, emailParam,
                      phoneNumberParam,sgkNumParam, userNameParam,roleParam });
        }
        public async Task EmployeeSafeDeleteAsync(int userId)
        {
            var userIdParam = new SqlParameter("@Id", userId);
            var IsDeleted = new SqlParameter("@IsDeleted", 1);

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE EmployeeSafeDelete @Id,@IsDeleted", parameters: new[] { userIdParam, IsDeleted });
        }
        public async Task<int> GetLastEmployeeIdAsync()
        {

            var result = await dbContext.Users.OrderByDescending(x => x.Id).Select(x=>x.Id).FirstOrDefaultAsync();
            return result;

        }
        public async Task<int> SalaryAddAsync(SalaryAddDto salaryAddDto)
        {
            var personelIdParam = new SqlParameter("@PersonelId", salaryAddDto.PersonelId);
            var salaryCoeParam = new SqlParameter("@SalaryCoefficient", salaryAddDto.SalaryCoefficient);
            var taxDeductionParam = new SqlParameter("@TaxDeduction", salaryAddDto.TaxDeduction);
            var sgkDeductionParam = new SqlParameter("@SgkDeduction", salaryAddDto.SgkDeduction);
            var salaryDateParam = new SqlParameter("@SalaryDate", salaryAddDto.SalaryDate);
            var additionalPayment = new SqlParameter("@AdditionalPayments", salaryAddDto.AdditionalPayments);

            var rowsAffectedParam = new SqlParameter("@RowsAffected", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE InsertSalary @PersonelId,@SalaryCoefficient,@TaxDeduction,@SgkDeduction,@SalaryDate,@AdditionalPayments,@RowsAffected OUTPUT", parameters:
                new[] { personelIdParam, salaryCoeParam, taxDeductionParam, sgkDeductionParam, salaryDateParam,additionalPayment,rowsAffectedParam });

            var rowsAffectedValue = (int)rowsAffectedParam.Value;
            return rowsAffectedValue;


        }
        public async Task<int> InsertWorkDayAsync(int personelId, DateTime? workDate, double? workTime)
        {
            var personelIdParam = new SqlParameter("@PersonelId", personelId);
            var workDateParam = new SqlParameter("@WorkDate", workDate);  
            var workTimeParam = new SqlParameter("@WorkTime", workTime);

            var rowsAffectedParam = new SqlParameter("@RowsAffected", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE InsertWorkDay @PersonelId, @WorkDate, @WorkTime,@RowsAffected OUTPUT", parameters: new[] { personelIdParam, workDateParam, workTimeParam,
            rowsAffectedParam});

            var rowsAffectedValue = (int)rowsAffectedParam.Value;

            return rowsAffectedValue;
        }

        public async Task CalculateSalary(int personelId)
        {
            var personelIdParam = new SqlParameter("@PersonelId", personelId);

            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE CalculateAndSaveSalary @PersonelId", parameters: new[] { personelIdParam });
        }
        public async Task InserRole(string roleName)
        {
            var roleParam = new SqlParameter("@RoleName", roleName);
            await dbContext.Database.ExecuteSqlRawAsync("EXECUTE InsertRole @RoleName", parameters: new[] { roleName });
        }
        public async Task<PaymentInfo> GetPayrollAsync(int personelId,int istenilenAy,int istenilenYıl)
        {
            var result = await dbContext.PaymentInfos
                            .FromSqlRaw("SELECT * FROM dbo.GetMonthlyPayrollForEmployee({0},{1},{2})", personelId, istenilenAy, istenilenYıl)
                            .FirstOrDefaultAsync();

            return result;
        }
        public async Task<List<AverageSalaryByDepartment>> GetAverageSalaryByDepartmentAsync()
        {
            var result = await dbContext.AverageSalaryByDepartments
                            .Select(a => new
                            {
                                AverageSalary = (double)a.AverageSalary,
                                a.DepertmanId
                                // Include other properties if needed
                            })
                            .ToListAsync();

            var averageSalaries = result.Select(a => new AverageSalaryByDepartment
            {
                AverageSalary = (float)a.AverageSalary,
                DepertmanId = a.DepertmanId
                // Map other properties if needed
            }).ToList();
            return averageSalaries;

        }
        public async Task<int> GetTotalEmployeeAsync()
        {

            var result = await dbContext.TotalEmployees
                .FromSqlRaw("SELECT TOP (1) TotalEmployeeCount FROM TotalEmployees")
                .FirstOrDefaultAsync();

            return result.TotalEmployeeCount;
        }
        public async Task<int> GetTotalDepartmanAsync()
        {

            var result = await dbContext.TotalDepartmanCounts
                .FromSqlRaw("SELECT TOP (1) ActiveDepartmanCount FROM TotalDepartmanCount")
                .FirstOrDefaultAsync();

            return result.ActiveDepartmanCount;
        }

    }
}
