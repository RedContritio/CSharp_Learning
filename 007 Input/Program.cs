using System;

namespace _007_Input
{
	class Program
	{
		static void Main( string[] args )
		{
			string x = Console.ReadLine();
			int y = Convert.ToInt32( x);
			y += 13;
			Console.WriteLine( y);
			Console.ReadKey();
		}
	}
}
