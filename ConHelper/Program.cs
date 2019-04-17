using System;
using System.Collections.Generic;
using System.Linq;

namespace ConHelper
{
	class Display
	{
		public static void ShowOptions(IEnumerable<string> options)
		{
			var optionDisplay = 1;
			var originalForeground = Console.ForegroundColor;
			foreach (var option in options)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write($"{optionDisplay}.) ");
				Console.ForegroundColor = originalForeground;
				Console.WriteLine(option);
				optionDisplay++;
			}
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Display.ShowOptions(new[] { "option a", "option b", "option c" });
			Console.WriteLine("Goodbye!");
		}
	}
}
