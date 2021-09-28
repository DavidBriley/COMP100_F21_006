using System;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			// Dynamic string generation.

			// Create a console program that prompts the user for the city he or she is from.
			// Display a message saying "<City> is a beautiful place!".

			Console.WriteLine("What city are you from? ");
			string city = Console.ReadLine();

			// String interpolation
			Console.WriteLine($"{city} is a beautiful place!");

			// String concatenation
			Console.WriteLine(city + " is a beautiful place!");

			// string.Format method
			Console.WriteLine(string.Format("{0} is a beautiful place!", city));
		}
	}
}
