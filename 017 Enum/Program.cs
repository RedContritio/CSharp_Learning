using System;

namespace _017_Enum
{
	class Program
	{
		enum Number_
		{
			zero, one, two, three, four, five, six, seven, eight, nine, ten
		};

		static void Main( string[] args )
		{
			Console.WriteLine( Number_.four);
			Console.WriteLine(( int)Number_.four);
			Console.WriteLine(( Number_)7);

			Console.ReadKey();
		}
	}
}
