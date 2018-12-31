using System;

namespace _008_Class
{
	class Program
	{
		class ASimpleClass
		{
			public int x ;
			public const int y = 5;
			public ASimpleClass()
			{
				;
			}
		}

		static void Main( string[] args )
		{
			ASimpleClass a = new ASimpleClass();
			Console.WriteLine( a.x);
			a.x = 22;
			Console.WriteLine( a.x);
			Console.WriteLine( ASimpleClass.y); // Hard to understand why it's necessary to use the class name
			Console.ReadKey();
		}
	}
}
