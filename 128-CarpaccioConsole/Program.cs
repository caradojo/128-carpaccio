using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _128_CarpaccioMsTest;

namespace _128_CarpaccioConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var terminal = new CarpaccioTermial(new ConsoleAdapter());

			terminal.DisplayQuantityQuestion();
			terminal.AskAndDisplayQuantity();
			terminal.DisplayPriceQuestion();
			terminal.AskAndDisplayPrice();

			Console.ReadLine();
		}
	}

	internal class ConsoleAdapter : IConsole
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}

		public void WriteLine(string s)
		{
			Console.WriteLine(s);
		}
	}
}
