using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
		const int WAGE_PER_HOUR = 20;
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation!");
			
			Random rand = new Random();
			int attendance = rand.Next(0, 3);
			int workingHours = 0;
			int dailywage;

			if (attendance == EMP_FULL_TIME)
			{
				workingHours = FULL_DAY_HOUR;
			}
			else if (attendance == EMP_PART_TIME)
			{
				workingHours = PART_TIME_HOUR;
			}
			dailywage = WAGE_PER_HOUR * workingHours;
			Console.WriteLine($"Daily Wage : {dailywage}");
		}
	}
}
