using System;

namespace CollectingUserInput
{
	class Program
	{
		static void Main(string[] args)
		{
			// Writing a program that collects the user's name, and displays a greeting message:

			Console.WriteLine("Please input your name: ");
			string name = Console.ReadLine();

			Console.WriteLine("Hello, " + name + "!");
		}
	}
}
