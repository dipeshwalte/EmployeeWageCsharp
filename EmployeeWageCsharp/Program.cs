using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		const int PRESENT = 1;
		const int ABSENT = 2;
		public static void Main(String[] args)
		{
			Console.WriteLine("Welcome to employee wage computation!");
			Random rand = new Random();
			int attendance = rand.Next(0, 2);
            if (attendance==PRESENT)
                Console.WriteLine("Employee Present");
			else
                Console.WriteLine("Employee Absent");
		}
	}
}
