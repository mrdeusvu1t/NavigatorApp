using System;
using System.Collections.Generic;
using System.Text;

namespace NavigatorApp
{
	class Road
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
				if (value == null || value.Length > 15)
				{
					throw new ArgumentOutOfRangeException(value);
				}

				_name = value;
			}
		}
		public readonly int Distance;
		public readonly int Speed;

		public Road(string name, int distance, int speed)
		{
			Name = name;
			Distance = distance;
			Speed = speed;
		}
	}
}
