using System;

namespace _013_NullAble
{
	class Program
	{
		static void Main( string[] args )
		{
			int a = 0;
			Console.WriteLine( "a : {0}", a);
			int? b = null;
			Console.WriteLine( "b : {0}", b);
			if( b == null)
			{
				Console.WriteLine( "b is null");
			}
			else
			{
				Console.WriteLine( "b is not null");
			}
			// int c = b;
			int c = b ?? 1; // if b == null , c = 1
			Console.WriteLine( "c is {0} now", c);

			Console.ReadKey();
		}
	}
}
