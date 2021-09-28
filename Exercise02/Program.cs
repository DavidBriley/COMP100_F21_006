using System;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			// Write a console application that prompts the user for:
			// - Product price
			// - Quantity
			// - Tax rate

			// And displays the order total, formatted as a currency value.

			// DECLARE VARIABLES
			double productPrice;
			double quantity;
			double taxRate;
			double orderTotal;

			// COLLECTING INPUT DATA
			Console.WriteLine("Please enter the product price: ");
			productPrice = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the quantity: ");
			quantity = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the tax rate in decimal format: ");
			taxRate = double.Parse(Console.ReadLine());

			// ALGORITHM
			orderTotal = productPrice * quantity * (1 + taxRate);

			// DISPLAY OUTPUT
			Console.WriteLine($"\nThe order total is {orderTotal:C}");

		}
	}
}
