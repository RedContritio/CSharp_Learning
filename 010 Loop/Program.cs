using System;

namespace _010_Loop
{
	class Program
	{
		static void Main( string[] args )
		{
			int x = 20;
			while( x>17)
			{
				Console.WriteLine( x--);
			}
			for( x--; x>11; x-=2) // similar to C/C++
			{
				Console.WriteLine( x);
			}
			int[] arr = new int[]{ 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,};
			foreach( int ele in arr)
			{
				Console.WriteLine( "Element : "+ele);
			}
			Console.ReadKey();
		}
	}
}
