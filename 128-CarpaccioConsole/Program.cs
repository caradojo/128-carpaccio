using System;
using System.Text;
using _128_CarpaccioMsTest;

namespace _128_CarpaccioConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			var terminal = new CarpaccioTermial(new ConsoleAdapter());

			terminal.DisplayQuantityQuestion();
			terminal.AskAndDisplayQuantity();
			terminal.DisplayPriceQuestion();
			terminal.AskAndDisplayPrice();

			terminal.DisplayTotal(22);

			Console.WriteLine("Appuyer sur une touche pour terminer");
			Console.ReadLine();

		}
	}
}
