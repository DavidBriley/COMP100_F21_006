using System;

namespace MathematicalOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			// This is where the magic happens.

			// Calculating the area of a square:
			double side = 5.5;
			double area = side * side;

			Console.WriteLine("The area is:");
			Console.WriteLine(area);

			// Mathematical operations are not possible between numbers and text.
			int number = 2;
			string text = "Something";

			// The line below gives an error.
			//int result = 2 * text;
		}
	}
}
