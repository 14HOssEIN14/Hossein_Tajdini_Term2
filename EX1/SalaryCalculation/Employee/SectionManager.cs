using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation.Employee;

public class SectionManager:IEmployee
{
    private string _name;
    private string _lastName;
    private string _nationalID;
    private double _baseSalary;
    private int _extraTimePerHours;
    public string Name { get { return _name; } set { _name = Validation.ValidateString(value, 100, 3); } }
    public string LastName { get { return _lastName; } set { _lastName = Validation.ValidateString(value, 100, 3); } }
    public string NationalID { get { return _nationalID; } set { _nationalID = Validation.ValidateNationalId(value); } }
    public int InsurancePeriod { get; set; }
    public double BaseSalary { get { return _baseSalary; } set { _baseSalary = Validation.ValidateBaseSalary(value, 10000, 5000); } }
    public double EmployeeRatio { get; set; }
    public double TotalHoursInMonth { get; set; }
    public int ExtraTimePerHours { get { return _extraTimePerHours; } set { _extraTimePerHours = Validation.ValidateExtraTimePerHours(value, 30, 0); } }
    public int? Level { get; set; }
    public TimeSpan WorkStartTime { get; set; }
    public TimeSpan WorkEndTime { get; set; }

    public double? CalculateSalary()
    {
        return ((BaseSalary * Level * EmployeeRatio * TotalHoursInMonth) +
                (BaseSalary * ExtraTimePerHours * Level * EmployeeRatio * 1.2));

    }

    public void ShowEmployee()
    {
        Console.WriteLine($@"Name:{Name}
LastName:{LastName}
NationalId:{NationalID}
EmployeeType:{nameof(SectionManager)} Level:{Level}
InsurancePeriod:{InsurancePeriod}Month
BaseSalary:{CalculateSalary()}
WorkTime:{WorkStartTime} to {WorkEndTime}");
    }


}
