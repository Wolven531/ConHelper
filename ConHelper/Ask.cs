using System;
namespace ConHelper
{
	public class Ask
	{
		public Ask()
		{
		}

		public static int ForInt(string message, bool displayTypeHint = false)
		{
			var userNumber = int.MinValue;
			var wasInteger = false;

			if (displayTypeHint)
			{
				message = $"{message} (numeric integer)";
			}

			while(!wasInteger)
			{
				Console.WriteLine(message);
				var lineInput = Console.ReadLine();
				wasInteger = int.TryParse(lineInput, out userNumber);
			}

			return userNumber;
		}
	}
}
