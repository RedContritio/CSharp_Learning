using System;

namespace _015_String
{
	class Program
	{
		static void Main( string[] args )
		{
			string str1 = "123456789", str2 = "abcdefg";
			string strcon = str1 + str2;
			char[] strch = { 'F', 'u', 'c', 'k'};
			string strcvs = new string( strch);
			string[] strarr = { str1, str2, strcvs};
			string strctt = String.Join( '@', strarr);

			Console.WriteLine( "str1 is {0}",str1);
			Console.WriteLine( "strcon is {0}", strcon);
			Console.WriteLine( "strch is {0}", strch);
			Console.WriteLine( "strcvs is {0}", strcvs);
			Console.WriteLine( "strctt is {0}", strctt);

			Console.ReadKey();
		}
	}
}
