using System;
using _128_CarpaccioMsTest;

namespace _128_CarpaccioConsole
{
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