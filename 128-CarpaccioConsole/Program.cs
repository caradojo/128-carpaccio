﻿using System;
using System.Text;

namespace _128_CarpaccioConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			var carpaccioConsoleProgram = new CarpaccioConsoleProgram(new ConsoleWriteLineAdapter(), new ConsoleReadLineAdapter());
			carpaccioConsoleProgram.Start();

			Console.WriteLine("Appuyer sur une touche pour terminer");
			Console.ReadLine();

		}
	}

	internal class ConsoleWriteLineAdapter : IConsoleWriteLine
	{
		public void WriteLine(string line)
		{
			Console.WriteLine(line);
		}
	}
}
