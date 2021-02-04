using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		
		static void ComputeWage(string companyName,int wagePerHour,int maxWorkingDays,int maxWorkingHours)
		{
			int workingHours = 0;
			int workingDays = 0;
			int wagesPerMonth = 0;
			Random rand = new Random();

			while (workingHours < maxWorkingHours && workingDays < maxWorkingDays)
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
				wagesPerMonth += (wagePerHour * workingHours);

			}//end while
			Console.WriteLine($"Wages for the company {companyName} for the month : {wagesPerMonth}");
		}
		public static void Main(String[] args)
		{
			ComputeWage("TCS",1000,20,100);
			ComputeWage("Rupak and Sons", 100, 30, 150);
		}
	}
}
