using System;

namespace _002_Rectangle
{
    class Rectangle
    {
        double width;
        double height;
        public void Set( double w, double h)
        {
			width = w;
			height = h;
        }
		public double Area()
		{
			return width*height;
		}
		public void Display()
		{
			Console.WriteLine( "Height:{0}", height);
			Console.WriteLine( "Width:{0}", width);
			Console.WriteLine( "Area:{0}", Area());
		}
    }
    class Program
    {
        static void Main(string[] args)
        {
			Rectangle a = new Rectangle();
			a.Set( 5, 2.3);
			a.Display();
			Console.ReadKey();
        }
    }
}
