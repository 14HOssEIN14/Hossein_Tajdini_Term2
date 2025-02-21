using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation;
public enum EmployeeType
{
    SimpleEmployee,
    SeniorEmployee,
    DepartmentManager,
    SectionManager,
    Assistance,
    CEO
}



public interface IEmployeeFactory
{
    IEmployee CreateEmployee(EmployeeType employeeType);
}
