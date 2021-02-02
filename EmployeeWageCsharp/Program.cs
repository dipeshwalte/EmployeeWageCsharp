using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		const int PRESENT = 1;
		const int WAGE_PER_HOUR = 20;
		const int FULL_DAY_HOUR = 8;
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation!");
			
			Random rand = new Random();
			int attendance = rand.Next(0, 2);
			int dailywage = 0;

			if (attendance == PRESENT)
            {
				dailywage = WAGE_PER_HOUR * FULL_DAY_HOUR;
			
			}
			Console.WriteLine($"Daily Wage : {dailywage}");
		}
	}
}
