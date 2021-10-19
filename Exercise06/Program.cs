using System;

namespace Exercise06 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			2.	Write a console-based program that prompts a user for an hourly pay rate. 
			If the value entered is less than $7.50 or greater than $49.99, display an error message; 
			otherwise, display a message indicating that the rate is okay.
			 
			*/

			// DECLARING VARIABLES
			double hourlyPay;
			string message;

			// COLLECTING INPUT
			Console.WriteLine("Please input the hourly pay rate: ");
			hourlyPay = double.Parse(Console.ReadLine());

			// ALGORITHM
			if (hourlyPay < 7.50 || hourlyPay > 49.99) {
				message = "ERROR: Hourly rate not accepted.";
			}
			else {
				message = "Hourly rate is accepted.";
			}

			// DISPLAY OUTPUT
			Console.WriteLine(message);
		}
	}
}
