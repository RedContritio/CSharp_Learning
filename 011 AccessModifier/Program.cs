using System;

namespace _011_AccessModifier
{
	class Rectangle
	{
		private double width, height;
		public Rectangle( double w, double h)
		{
			width = w;
			height = h;
		}
		public double Area()
		{
			return width* height;
		}
		public void SetWidth( double w)
		{
			width = w;
		}
		public void SetHeight( double h)
		{
			height = h;
		}
		public void Display()
		{
			Console.WriteLine( "("+width+","+height+") = "+Area());
		}
	};

	class Program
	{
		static void Main( string[] args )
		{
			Rectangle x= new Rectangle( 20, 35.5);
			x.Display();
			Console.ReadKey();
		}
	}
}
