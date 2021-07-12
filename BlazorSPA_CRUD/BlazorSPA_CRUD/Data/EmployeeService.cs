using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorSPA_CRUD.Data
{
    public class EmployeeService
    {
        private readonly AppDBContext _appDBContext;

        public EmployeeService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Get All Employees
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _appDBContext.Employees.ToListAsync();
        }

        // Add an Employee
        public async Task<bool> AddEmployeeAsync(Employee employee)
        {
            await _appDBContext.Employees.AddAsync(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Get Employee by Id
        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {
            Employee employee = await _appDBContext.Employees.FirstOrDefaultAsync(c => c.EmpId == Id);
            return employee;
        }

        // Update Employyee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _appDBContext.Employees.Update(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete Employee
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            _appDBContext.Remove(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }

}
