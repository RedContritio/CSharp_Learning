using System;

namespace _014_Array
{
	class Program
	{
		static void Main( string[] args )
		{
			int[] arr0 = new int[10];
			int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
			int[] arr2 = new int[5] { 1, 2, 3, 4, 5,}; // the static array must be the size 'n'
			int[] arr3 = new int[] { 1, 2, 3, 4}; // If there is no 'n' limit, so. 

			int[] arr4 = arr3;

			arr4[1] = 233;
			Console.WriteLine( "arr4[1] = {0}", arr4[1]);
			Console.WriteLine( "arr3[1] = {0}", arr3[1]);
			// So it is a reference of the data.
			foreach( int i in arr4)
			{
				Console.Write( "{0},", i);
			}
			Console.ReadKey();
		}
	}
}
