using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCsharp
{
    class CompanyEmpWage
    {
        public readonly string companyName;
        public readonly int wagePerHour;
        public readonly int maxWorkingDays;
        public readonly int maxWorkingHours;
        int wagesPerMonth = 0;

        public CompanyEmpWage(string companyName, int wagePerHour,int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setWagesPerMonth(int wagesPerMonth)
        {
            this.wagesPerMonth = wagesPerMonth;
        }
        public void printMonthlyWage()
        {
            Console.WriteLine($"Wages for the company {companyName} for the month : {wagesPerMonth}");
        }
    }
}
