using System;

namespace _019_Inheritance
{
	class Base
	{
		static string str = "";
		public void ClassIdentify()
		{
			Console.WriteLine( "<Base Class>");
		}
	};

	class Shape: Base
	{
		
	};
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine("Hello World!");
		}
	}
}
