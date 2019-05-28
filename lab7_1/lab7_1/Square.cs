using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_1
{
	public interface IMeasurable
	{
		double Perimeter();
		double Area();
	}

	public interface ICircumcircleIncircle
	{
		double R { get; }
		double r { get; }
	}

	public class Square : DemoPoint, IMeasurable, IComparable<Square>
	{
		public Square(int x, int y) : base(x, y) { }

		public double Perimeter() => X * 2 + Y * 2;
		public double Area() => Math.Pow(X + Y, 2);

		int IComparable<Square>.CompareTo(Square someSquare)
		{
			return Perimeter().CompareTo(someSquare.Perimeter());
		}

		static void Main()
		{
			Square[] squares = new Square[5]
			{
				new Square(8, 10),
				new Square(3, 9),
				new Square(10, 2),
				new Square(4, 11),
				new Square(7, 3)
			};

			Console.WriteLine("Неотсортований масив:\n");
			foreach (var element in squares)
			{
				Console.WriteLine("Периметр: " + element.Perimeter());
			}

			Array.Sort<Square>(squares);

			Console.WriteLine("\nНовий отсортований масив:\n");
			foreach (var element in squares)
			{
				Console.WriteLine("Периметр: " + element.Perimeter());
			}

			Console.ReadLine();
		}
	}
}