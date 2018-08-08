using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDal
    {
        public Employee GetEmployeeById(string employeeId);
        public Emplpyee GetEmployeeByName(string employeName);
        public string GetEmployeePositionById(string employeeId);
        public int GetEmployeeCount();
    }
}
