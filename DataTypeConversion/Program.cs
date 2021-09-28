using System;

namespace DataTypeConversion {
	class Program {
		static void Main(string[] args) {
			// Everything the user types in the console is a string.
			string inputPrice = "14.99";
			string inputQuantity = "3";
			string inputHasDiscount = "false";
			string inputCashier = "H";

			// Converting string to double
			//double price = Convert.ToDouble(input);
			double price = double.Parse(inputPrice);

			// Converting string to int
			int quantity = Convert.ToInt32(inputQuantity);
			//int quantity = int.Parse(inputQuantity);

			// Converting string to bool
			//bool hasDiscount = Convert.ToBoolean(inputHasDiscount);
			bool hasDiscount = bool.Parse(inputHasDiscount);

			// Converting string to char
			char cashier = Convert.ToChar(inputCashier);
			//char casher = char.Parse(inputCashier);


			// Casting is a data type conversion technique that can be used
			// as long as we are not converting to or from a string

			// Example: Converting 20 degrees Celsius to Fahrenheit

			double celsius = 20;
			double fahrenheit = (double)9 / 5 * celsius + 32;

			Console.WriteLine(fahrenheit);
		}
	}
}
