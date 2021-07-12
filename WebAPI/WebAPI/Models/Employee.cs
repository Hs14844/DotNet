using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public DateTime HireDate { get; set; }
    }
}
