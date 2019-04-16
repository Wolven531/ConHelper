using System;

namespace ConHelper
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Before 1...");
			Console.WriteLine("Before 2...");
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Hello World!");
			Console.ResetColor();
			Console.WriteLine("After 1...");
			Console.WriteLine("After 2...");
		}
	}
}
