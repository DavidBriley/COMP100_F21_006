using System;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			// This is where the magic happens!
			
			// Declaring local variables that store text:
			string username;
			string firstName;

			// Initializing a local variable:
			firstName = "John";

			// Declaring and initializing at the same time:
			string lastName = "Smith";

			// Working with local variables that store integers:
			//int age;
			//age = 25;
			int age = 25;

			// Working with local variables that store floating-point numbers:
			double gpa;
			gpa = 4.5;
			// double gpa = 4.5;

			// Sometimes, even numeric values are treated as text.
			// They can be treated as text when the fact that they are numbers is irrelevant.
			string sinNumber = "123456789";

			// In C#, text (or strings) has to be surrounded with DOUBLE quotes.
			// Numeric values, however, cannot have any quotes around them.

			// Working with characters:
			char initial = 'L';

			// In C#, single quotes are used for character values.

			// Working with booleans:
			bool isStudent = true;


		}
	}
}
