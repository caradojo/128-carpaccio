using System;
using System.Text;

namespace _128_CarpaccioConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			var carpaccioConsoleProgram = new CarpaccioConsoleProgram();

			Console.WriteLine("Appuyer sur une touche pour terminer");
			Console.ReadLine();

		}
	}
}
