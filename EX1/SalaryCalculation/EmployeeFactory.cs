using SalaryCalculation.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation;

public class EmployeeFactory : IEmployeeFactory
{
    public IEmployee CreateEmployee(EmployeeType employeeType)
    {
        switch (employeeType)
        {
            case EmployeeType.SimpleEmployee: return new SimpleEmployee();
            case EmployeeType.SeniorEmployee: return new SeniorEmployee();
            case EmployeeType.SectionManager: return new SectionManager();
            case EmployeeType.Assistance: return new Assistance();
            case EmployeeType.CEO: return new CEO();
            case EmployeeType.DepartmentManager: return new DepartmentManager();
            default: throw new Exception("Type Invalid");
        }
    }
}
