using System;
using System.Collections.Generic;

namespace ConHelper
{
	public class Display
	{
		public Display()
		{
		}

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
}
