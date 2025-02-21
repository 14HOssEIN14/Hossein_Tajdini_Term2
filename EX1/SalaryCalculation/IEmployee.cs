using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation;

public interface IEmployee
{
    string Name { get; set; }
    string LastName { get; set; }
    string NationalID { get; set; }
    int InsurancePeriod { get; set; }
    int? Level { get; set; }
    double BaseSalary { get; set; }
    double EmployeeRatio { get; set; }
    double TotalHoursInMonth { get; set; }
    int ExtraTimePerHours { get; set; }
    TimeSpan WorkStartTime { get; set; }
    TimeSpan WorkEndTime { get; set; }


    double? CalculateSalary();
    void ShowEmployee();
}
