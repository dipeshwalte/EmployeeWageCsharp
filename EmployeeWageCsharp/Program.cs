using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		const int WAGE_PER_HOUR = 20;
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		const int MAX_WORKING_DAYS = 20;
		const int MAX_WORKING_HOURS = 100;
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation!");
			int workingHours = 0;
			int workingDays = 0;
			int wagesPerMonth = 0;
			Random rand = new Random();

			while (workingHours < MAX_WORKING_HOURS && workingDays < MAX_WORKING_DAYS)
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
				wagesPerMonth += (WAGE_PER_HOUR * workingHours);

			}//end while
			Console.WriteLine("Wages for the Month: " + wagesPerMonth);
		}
	}
}
