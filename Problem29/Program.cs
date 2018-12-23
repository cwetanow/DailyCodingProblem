using System;
using System.Text;

namespace Problem29
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var encoded = Encode(input);

			Console.WriteLine(encoded);

			var decoded = Decode(encoded);

			Console.WriteLine(decoded);
		}

		public static string Encode(string input)
		{
			var builder = new StringBuilder();

			var currentChar = input[0];
			var counter = 1;

			for (var i = 1; i < input.Length; i++)
			{
				if (input[i] == currentChar)
				{
					counter++;
				}
				else
				{
					builder.Append($"{counter}{currentChar}");

					counter = 1;
					currentChar = input[i];
				}
			}

			builder.Append($"{counter}{currentChar}");

			var result = builder.ToString();

			return result;
		}

		public static string Decode(string encoded)
		{
			var builder = new StringBuilder();

			for (var i = 0; i < encoded.Length; i++)
			{
				var countString = string.Empty;

				while (i < encoded.Length && char.IsDigit(encoded[i]))
				{
					countString += encoded[i];
					i++;
				}

				var count = int.Parse(countString);

				var character = encoded[i];

				for (var j = 0; j < count; j++)
				{
					builder.Append(character);
				}
			}

			var result = builder.ToString();

			return result;
		}
	}
}
