using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Select the program to run.");
			string program = Console.ReadLine();
			
			switch(program)
			{
				case "ChuckNorris":
					ChuckNorris.Unary();
					break;

				default:
					Console.WriteLine("Program not found.");
					break;
			}

			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
		}
	}
}
