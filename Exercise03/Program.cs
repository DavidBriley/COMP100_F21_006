using System;

namespace Exercise03 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			/*
			
			Write a program to ask the user about the validity of a simple statement. 
			
			The program should accept the response then display the statement as well as the response. 
			The response should be true or false. For this question, you must use a variable of type bool. 
			It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.

			*/

			// DECLARE VARIABLES
			bool response;
			string statement = "In C#, variables can be declared and initialized at the same time.";

			// COLLECT INPUT
			Console.WriteLine(statement);
			Console.WriteLine("True or false?");
			response = Convert.ToBoolean(Console.ReadLine());

			// ALGORITHM

			// DISPLAY OUTPUT
			Console.WriteLine("\nThe sentence was:");
			Console.WriteLine(statement);
			Console.WriteLine($"\nThe input was: {response}");
			Console.WriteLine("The correct answer was: true");
		}
	}
}
