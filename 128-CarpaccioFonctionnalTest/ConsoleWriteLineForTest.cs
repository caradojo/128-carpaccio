using System.Text;
using _128_CarpaccioConsole;

namespace _128_CarpaccioFonctionnalTest
{
	public class ConsoleWriteLineForTest : IConsoleWriteLine
	{
		private readonly StringBuilder _output;

		public ConsoleWriteLineForTest()
		{
			_output = new StringBuilder();
		}

		public string Output
		{
			get { return _output.ToString(); }
		}

		public void WriteLine(string line)
		{
			_output.AppendLine(line);
		}
	}
}