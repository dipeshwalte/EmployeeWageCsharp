using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCsharp
{
    class EmpWageBuilder : IComputeEmpWage
    {
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		Dictionary<string,CompanyEmpWage>  companiesDictionary;
		public EmpWageBuilder()
		{
			companiesDictionary = new Dictionary<string, CompanyEmpWage>();
		}
		public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			CompanyEmpWage company = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
			company.setDailyWage(this.ComputeDailyWage(company));
			company.setWagesPerMonth(this.ComputeMonthlyWage(company));
			companiesDictionary.Add(companyName,company);
		}
		public void AddCompany(CompanyEmpWage company)
		{
			company.setDailyWage(this.ComputeDailyWage(company));
			company.setWagesPerMonth(this.ComputeMonthlyWage(company));
			companiesDictionary.Add(company.companyName,company);
		}
		public int ComputeMonthlyWage(CompanyEmpWage company)
		{
			int workingHours = 0;
			int workingDays = 0;
			int wagesPerMonth = 0;
			Random rand = new Random();

			while (workingHours < company.maxWorkingHours && workingDays < company.maxWorkingDays)
			{
				int attendance = rand.Next(0, 3);
				int hoursWorked = 0;
				switch (attendance)
				{
					case EMP_FULL_TIME:
						workingDays += 1;
						hoursWorked = FULL_DAY_HOUR;
						break;
					case EMP_PART_TIME:
						workingDays += 1;
						hoursWorked = PART_TIME_HOUR;
						break;
					default:
						break;
				}//end Switch

				workingHours += hoursWorked;
				wagesPerMonth += (company.wagePerHour * workingHours);

			}//end while
			return wagesPerMonth;	
		}

		public int ComputeDailyWage(CompanyEmpWage company)
		{
			return FULL_DAY_HOUR * company.wagePerHour;
		}

		public void DisplayCompanyMonthlyWages()
		{
            foreach (var companyEntry in companiesDictionary)
            {
				companyEntry.Value.printMonthlyWage();
            }
		}

		public void DisplayCompanyDailyWages()
		{
			foreach (var companyEntry in companiesDictionary)
			{
				companyEntry.Value.printDailyWage();
			}
		}

		public int GetMonthlyWageByCompanyName(string companyName)
		{
			return companiesDictionary[companyName].wagesPerMonth;
		}
	}
}
