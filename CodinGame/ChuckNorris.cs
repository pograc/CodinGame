using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame
{
	class ChuckNorris
	{
		public static void Unary()
		{
			while (true)
			{
				Console.WriteLine("Enter phrase to encode with Unary.");
				string message = Console.ReadLine();

				if (message.Equals("exit"))
					break;

				List<int> binary = new List<int>();

				foreach (char c in message)
				{
					var a = (int)c;
					string b = string.Concat("0000000", Convert.ToString(a, 2));
					binary.AddRange(b.Substring(b.Length - 7).ToCharArray().Select(x => (int)x).ToList());
				}

				int previous = -2;

				string output = string.Empty;

				binary.ForEach(current =>
				{
					if (current != previous)
					{
						if (current == 49)
							output = string.Concat(output, " 0 ");
						else
							output = string.Concat(output, " 00 ");

						previous = current;
					}

					output = string.Concat(output, "0");
				});

				Console.WriteLine(output.Trim());
			}
		}
	}
}
