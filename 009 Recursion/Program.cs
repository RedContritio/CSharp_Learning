using System;

namespace _009_Recursion
{
	class Program
	{
		static int Recursion( int n)
		{
			if( n < 2)
			{
				return 1;
			}
			return n*Recursion(n-1);
		}
		static void Main( string[] args )
		{
			Console.WriteLine( Recursion(5));
			Console.ReadKey();
		}
	}
}
