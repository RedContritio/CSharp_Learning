using System;

namespace _004_ReferencedType
{
	class Program
	{
		static void Main( string[] args )
		{
			int a = 10;
			object box = a;
			Console.WriteLine( "{0}, {1}", a, box);
			a = 12;
			Console.WriteLine( "{0}, {1}", a, box);
			box = 14;
			Console.WriteLine( "{0}, {1}", a, box);
			dynamic d = box;
			Console.WriteLine( "{0}, {1}, {2}", a, box, d);
			d = 20;
			Console.WriteLine( "{0}, {1}, {2}", a, box, d);
			Console.ReadKey();
		}
	}
}
