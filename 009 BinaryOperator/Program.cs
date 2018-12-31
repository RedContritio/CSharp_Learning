using System;

namespace _009_BinaryOperator
{
	class Program
	{
		static void Main( string[] args )
		{
			int x = 97, y = 4;
			Console.WriteLine( x+y);
			Console.WriteLine( x-y);
			Console.WriteLine( x*y);
			Console.WriteLine( x/y);
			Console.WriteLine( x%y);
			Console.WriteLine( x<<y);
			Console.WriteLine( x>>y);
			Console.ReadKey();

			/* These operations is the same as it in cxx */

			Console.WriteLine( x is int);
			object z = x;
			Console.WriteLine( z is double);
			Console.WriteLine( z is int);
			// In fact, do not I know that what it really is, I mean the keyword "as"
			Console.ReadKey();
		}
	}
}
