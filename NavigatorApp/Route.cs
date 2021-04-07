using System;
using System.Collections.Generic;
using System.Text;

namespace NavigatorApp
{
	class Route
	{
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != null || value.Length < 15)
				{
					_name = value;
				}
			}
		}
		public readonly Road Start;
		public readonly Road End;
		public Road[] Roads { get; set; }

		public Route(string name, Road start, Road end, params Road[] roads)
		{
			Name = name;
			Start = start;
			End = end;
			Roads = roads;
		}

		private string Time()
		{
			int distance = 0;
			int speed = 0;

			for (int i = 0; i < Roads.Length; i++)
			{
				distance += Roads[i].Distance;
				speed += Roads[i].Speed;
			}

			speed = speed / Roads.Length;

			int hours = distance / speed;
			int minutes = distance % speed;

			return string.Format($"{hours}h {minutes}m");
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Пункт назначения: {End.Name}");
			Console.WriteLine($"Маршрут:");
			
			foreach (Road r in Roads)
			{
				Console.WriteLine($"{r.Name}");
			}

			Console.WriteLine($"Время, чтобы добраться: {Time()}");
		}
	}
}
