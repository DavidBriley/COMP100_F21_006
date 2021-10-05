using System;

namespace Exercise04 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			/*
			 
			Write a program that prompts the user for a number (that may be a fraction). 
			
			The program reads in the input and print the following: the input as a double, the input as an int and finally the input as a char.
			e.g. if the input is 65.790, then the output will be 65.790, 65, and A. 
			 
			*/

			// DECLARE VARIABLES
			double numerator;
			double denominator;

			// COLLECT INPUT
			Console.WriteLine("Please input the numerator: ");
			numerator = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please input the denominator: ");
			denominator = Convert.ToDouble(Console.ReadLine());

			// ALGORITHM

			// DISPLAY OUTPUT
			Console.WriteLine($"\nOutput as char: {(char)(numerator / denominator)}");
			Console.WriteLine($"Output as double: {(numerator / denominator):F3}");
			Console.WriteLine($"Output as int: {(int)numerator / (int)denominator}");
		}
	}
}
