using System;

namespace _012_OutArgument
{
	class HHH
	{
		static public int Square( out int a, int n)
		{
			a = n*n;
			return (n!=0)?1:0;
		}
	};

	class Program
	{
		static void Main( string[] args )
		{
			int b=5, a=3;
			if( HHH.Square( out a, b) !=0)
			{
				Console.WriteLine( a + " "+ b);
			}
			b = 0 ;
			if( HHH.Square( out a, b) !=0)
			{
				Console.WriteLine( a + " "+ b);
			}
			b = -4 ;
			if( HHH.Square( out a, b) !=0)
			{
				Console.WriteLine( a + " "+ b);
			}
			Console.ReadKey();
		}
	}
}
