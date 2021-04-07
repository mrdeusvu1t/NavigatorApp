using System;

namespace NavigatorApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Road r1 = new Road("Road1", 20, 40);
			Road r2 = new Road("Road2", 50, 50);
			Road r3 = new Road("Road3", 100, 30);
			Road r4 = new Road("Road4", 10, 60);
			Road r5 = new Road("Road5", 40, 45);
			Road r6 = new Road("Road6", 0, 0);

			Route route = new Route("Route", r1, r6, r1, r2, r3, r4, r6);

			route.DisplayInfo();

			Console.ReadKey();
		}
	}
}
