using System;

namespace _003_ValueTypes
{
	class Program
	{
		static void Main( string[] args )
		{
			bool valBool = false;
			byte valByte = 0x41;
			char valChar = 'a';
			decimal valDec = 12345678912345678912345M;
			float valFlt = 0.123456789123456789F;
			double valDouble = 0.123456789123456789;
			uint valUint = 14151251;
			ValueType a = 1231242152521512351142415261M;
			Console.WriteLine( "{0}, {1}", valBool, sizeof(bool));
			Console.WriteLine( "{0}, {1}", valByte, sizeof(byte));
			Console.WriteLine( "{0}, {1}", valChar, sizeof(char));
			Console.WriteLine( "{0}, {1}", valDec, sizeof(decimal));
			Console.WriteLine( "{0}, {1}", valFlt, sizeof(float));
			Console.WriteLine( "{0}, {1}", valDouble, sizeof(double));
			Console.WriteLine( "{0}, {1}", valUint, sizeof(uint));
			Console.WriteLine( "{0}", a);
			Console.ReadKey();
		}
	}
}
