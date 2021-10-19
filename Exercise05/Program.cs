using System;

namespace Exercise05 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			1.	Write a console-based program that prompts the user for an hourly pay rate. 
			If the value entered is less than $7.50, display an error message.

			*/

			// DECLARING VARIABLES
			double hourlyPay;
			string message;

			// COLLECTING INPUT
			Console.WriteLine("Please input the hourly pay rate: ");
			hourlyPay = double.Parse(Console.ReadLine());

			// ALGORITHM
			if (hourlyPay < 7.50) {
				message = "ERROR: Hourly rate less than $7.50.";
			}
			else {
				message = "Hourly rate is accepted.";
			}

			// DISPLAY OUTPUT
			Console.WriteLine(message);
		}
	}
}
