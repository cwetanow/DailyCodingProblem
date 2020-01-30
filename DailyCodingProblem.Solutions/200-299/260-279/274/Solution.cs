using System.IO;

namespace DailyCodingProblem.Solutions.Problem274
{
	public class Solution
	{
		public static int Eval(string input)
		{
			input = input.Replace(" ", string.Empty);
			var reader = new StringReader(input);


			return Eval(reader);
		}

		private static int Eval(StringReader reader)
		{
			var result = 0;
			var currentSign = '+';

			while (true)
			{
				var next = reader.Read();

				if (next < 0)
				{
					return result;
				}

				var nextChar = (char)next;
				if (nextChar == ')')
				{
					return result;
				}

				if (char.IsNumber(nextChar))
				{
					var number = int.Parse(nextChar.ToString());
					if (currentSign == '-')
					{
						number *= -1;
					}

					result += number;
				}
				else if (nextChar == '(')
				{
					var number = Eval(reader);
					if (currentSign == '-')
					{
						number *= -1;
					}

					result += number;
				}
				else
				{
					currentSign = nextChar;
				}
			}
		}
	}
}
