using System;

namespace EmployeeWageCsharp
{
	public class Program
	{
		
		public static void Main(String[] args)
		{
			EmpWageBuilder TCS = new EmpWageBuilder("TCS", 1000, 20, 100);
			TCS.ComputeWage();
            Console.WriteLine(TCS.ToString());
			EmpWageBuilder RupakAndSons = new EmpWageBuilder("Rupak and Sons", 100, 30, 150);
			RupakAndSons.ComputeWage();
            Console.WriteLine(RupakAndSons.ToString());
		}
	}
}
