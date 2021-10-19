using System;

namespace IfStatements {
	class Program {
		static void Main(string[] args) {
			// IF STATEMENTS

			// If statements are control structures that
			// also define whether a code block should run.

			// If statements have two parts:
			// 1. Declaration (header).
			// 2. Body.
			// 3. Sometimes, if statements will have "else" statements.
			// 4. Sometimes, if statements will have "else if" statements.

			// Boolean statements are statements that return
			// true or false.

			// Ex.: It is raining outside.
			// > false.

			// Ex.: The lights are on.
			// > true.

			// Ex.: 3 > 5
			// > false.

			// Ex.: 10 >= 5
			// > true.

			// Boolean statements can use comparison operators.
			// ==
			// !=
			// >
			// >=
			// <
			// <=

			// We are working on a program that outputs different messages
			// depending on the city provided by the user.

			string city = "Toronto";

			if (city == "Toronto") {
				// This will only run if city is "Toronto".
				Console.WriteLine("Toronto is a city in Canada.");
			}
			else if (city == "New York") {
				// This will only run if the first scenario is false.
				Console.WriteLine("New York is a city in the US.");
			}
			else if (city == "Paris") {
				// This will only run if the first two scenarios are false.
				Console.WriteLine("Paris is a city in France.");
			}
			else {
				// This will run if none of the statements above return true.
				Console.WriteLine("I do not know that city.");
			}


			// ===================================================================================


			// Compound Boolean Expressions

			// Logical operators are used to combine simple Boolean expressions.
			// And: && (Requires both sides to be true in order to return true).
			// Or:  || (Requires both sides to be false in order to return false).
			// Not: ! (Flips a boolean value. If true, it becomes false. If false, it becomes true).

			if ((10 > 5) && (10 == -1)) {
				Console.WriteLine("This is TRUE.");
			}
			else {
				Console.WriteLine("This is FALSE.");
			}
		}
	}
}
