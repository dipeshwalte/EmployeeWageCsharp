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
		const int MAX_WORKING_DAYS = 20;
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation!");
			int monthlyWage = 0;
			Random rand = new Random();
			
            for (int i = 0; i < MAX_WORKING_DAYS; i++)
            {
				int attendance = rand.Next(0, 3);
				int hoursWorked = 0;
				switch (attendance)
				{
					case EMP_FULL_TIME:
						hoursWorked = FULL_DAY_HOUR;
						break;
					case EMP_PART_TIME:
						hoursWorked = PART_TIME_HOUR;
						break;
					default:
						break;
				}//end Switch

				monthlyWage += WAGE_PER_HOUR * hoursWorked;
			}

			
			Console.WriteLine($"Monthly Wage : {monthlyWage}");
		}
	}
}
