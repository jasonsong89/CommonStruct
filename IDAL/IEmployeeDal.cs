using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IEmployeeDal
    {
        Employee GetEmployeeById(string employeeId);
        Employee GetEmployeeByName(string employeName);
        string GetEmployeePositionById(string employeeId);
        int GetEmployeeCount();
    }
}
