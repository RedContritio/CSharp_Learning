using System;

namespace _005_StringType
{
	class Program
	{
		static void Main( string[] args )
		{
			string str1 = "server\ntest";
			string str2 = @"server\ntest";
			string str3 = @"<script type=""text/javascript"">
<!-- Magic!!! --!>
</script>";
			// if I use @ , it legal to use "" to express '\"'
			// but in a normal string, I can only use \"
			Console.WriteLine( str1);
			Console.WriteLine( str2);
			Console.WriteLine( str3);
			Console.ReadKey();
		}
	}
}
