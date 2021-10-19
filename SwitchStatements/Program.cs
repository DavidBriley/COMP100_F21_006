using System;

namespace SwitchStatements {
	class Program {
		static void Main(string[] args) {
			// Here is where the magic happens.

			// SWITCH STATEMENTS
			// Switch statements are conditional structures that define
			// whether a code block will run.

			// We are working on a program that outputs different messages
			// depending on the city provided by the user.

			string city = "Toronto"; 

			// Switch statements have two parts:
			// 1. Declaration (header).
			// 2. Cases.

			switch (city) {
				// Cases go inside the switch.
				// Cases must end with a "break".
				case "Toronto":
					Console.WriteLine("Toronto is a city in Canada.");
					break;
				case "New York":
					Console.WriteLine("New York is a city in the US.");
					break;
				case "Paris":
					Console.WriteLine("Paris is a city in France.");
					break;

				// Optionally, a default case can be defined.
				// It will run for all possible scenarios not defined above.
				default:
					Console.WriteLine("I do not know that city.");
					break;
			}
		}
	}
}
