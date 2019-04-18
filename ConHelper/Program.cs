using System;

namespace ConHelper
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Display.ShowOptions(new[] { "option a", "option b", "option c" });
			var age = Ask.ForInt("How old are you?");

			Console.WriteLine($"Goodbye {age} year old!");
		}
	}
}
