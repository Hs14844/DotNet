using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees = new List<Employee>
    {
        //new Employee{ Id=1, Name="Shardul Sen", Department="Marketing", Salary=15000, HireDate=Convert.ToDateTime("12/12/2015")},
        //new Employee{ Id=2, Name="Samarth Pal", Department="Marketing", Salary=18000, HireDate=Convert.ToDateTime("12/02/2011")},
        //new Employee{ Id=3, Name="Parth Shah", Department="Software", Salary=25000, HireDate=Convert.ToDateTime("02/12/2016")},
        //new Employee{ Id=4, Name="Atharv Kalicharan", Department="Finance", Salary=17000, HireDate=Convert.ToDateTime("12/06/2018")},
        //new Employee{ Id=5, Name="Prakash Kale", Department="Finance", Salary=20000, HireDate=Convert.ToDateTime("02/04/2013")},
        //new Employee{ Id=6, Name="Ajinkya Malpani", Department="Software", Salary=35000, HireDate=Convert.ToDateTime("02/10/2019")},
    };

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.EmpId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<IEnumerable<Employee>> Post(Employee newEmployee)
        {
            employees.Add(newEmployee);
            return employees;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Employee>> Put(int id, Employee updatedEmployee)
        {
            Employee employee = employees.FirstOrDefault(e => e.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.EmpName = updatedEmployee.EmpName;
            //employee.Department = updatedEmployee.Department;
            //employee.Gender = updatedEmployee.Gender;
            //employee.City = updatedEmployee.City;
            //employee.HireDate = updatedEmployee.HireDate;

            return employees;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Employee>> Delete(int id)
        {
            Employee employee = employees.FirstOrDefault(e => e.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }

            employees.Remove(employee);

            return employees;
        }
    }
}
