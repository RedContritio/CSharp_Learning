using System;

namespace _006_TypeConversion
{
	class Program
	{
		static void ExplicitConversion()
		{
			double x = 100.999;
			int y = (int)x;
			Console.WriteLine( y);
		}

		static void ImplicitConversion()
		{
			int x = 105;
			double y = x;
			Console.WriteLine( y);
		}

		static void ToConversion()
		{
			double x = 0.231243512512;
			string y = x.ToString();
			Console.WriteLine( y);
		}

		static void Main( string[] args )
		{
			ExplicitConversion();
			ImplicitConversion();
			ToConversion();
			Console.ReadKey();
		}
	}
}
