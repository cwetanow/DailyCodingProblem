using System;

namespace Problem26
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var list = new LinkedList<int>();

			for (int i = 1; i < 11; i++)
			{
				list.Add(i);
			}

			var k = int.Parse(Console.ReadLine());

			var number = list.RemoveKthLastElement(k);

			Console.WriteLine(number);
		}
	}
}
