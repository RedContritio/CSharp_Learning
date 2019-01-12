using System;

namespace _016_Struct
{
	struct Token
	{
		public char token;
		public string description;
		public int id;
		public void display()
		{
			Console.WriteLine( "Token symbol : {0}", token);
			Console.WriteLine( "Token description : {0}", description);
			Console.WriteLine( "Token id : {0}", id);
			Console.WriteLine();
		}
	};


	class Program
	{
		static void PrintTokenInfo( Token t)
		{
			t.display();
		}

		static void Main( string[] args )
		{
			Token a;
			a.token = '@';
			a.description = "This is an at token";
			a.id = 0;
			
			PrintTokenInfo( a);
			
			Console.WriteLine( "Print End.");
			Console.ReadKey();
		}
	}
}
