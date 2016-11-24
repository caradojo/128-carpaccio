using System;

namespace _128_CarpaccioConsole
{
	internal class ConsoleWriteLineAdapter : IConsoleWriteLine
	{
		public void WriteLine(string line)
		{
			Console.WriteLine(line);
		}
	}
}