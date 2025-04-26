using SalaryCalculation;
IEmployeeFactory employeeFactory = new EmployeeFactory();
IEmployee employee = employeeFactory.CreateEmployee(EmployeeType.CEO);
employee.Name = "Mamad";
employee.LastName = "Gholi";
employee.NationalID = "3813076301";
employee.InsurancePeriod = 365;
employee.BaseSalary = 6502;
employee.EmployeeRatio = 1;
employee.TotalHoursInMonth = 170;
employee.ExtraTimePerHours = 15;
employee.Level = 2;
employee.WorkStartTime = TimeSpan.Parse("08:30");
employee.WorkEndTime = TimeSpan.Parse("18:00");
employee.ShowEmployee();


