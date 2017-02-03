using System;

namespace DayOFWeek
{
	class MainClass
	{
		public static void Main()
		{
			string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			var arrayNum = int.Parse(Console.ReadLine());

			if (arrayNum <= 0 || arrayNum > 7)
			{
				Console.WriteLine("Invalid Day!");
				return;
			}

			for (var i = 0; i <= days.Length; i++)
			{
				if (i == arrayNum )
				{
					Console.WriteLine(days[i - 1]);
				}
			}
		}
	}
}