using System;
using System.Text;

namespace EmployeeWageCsharp
{
    class EmpWageBuilder
    {
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		CompanyEmpWage[] companies;
		int noOfCompanies;
		public EmpWageBuilder()
		{
			companies = new CompanyEmpWage[10];
			noOfCompanies = 0;
		}
		public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			CompanyEmpWage company = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
			company.setWagesPerMonth(this.ComputeMonthlyWage(company));
			companies[noOfCompanies] = company;
			noOfCompanies++;
		}
		public void AddCompany(CompanyEmpWage company)
		{
			company.setWagesPerMonth(this.ComputeMonthlyWage(company));
			companies[noOfCompanies] = company;
			noOfCompanies++;
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

		public void DisplayCompanyWages()
		{
            for (int i = 0; i < noOfCompanies; i++)
            {
				companies[i].printMonthlyWage();
            }
		}

	}
}
