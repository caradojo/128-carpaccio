using System;
using System.Text;

namespace _128_CarpaccioMsTest
{
	public class TestConsole : IConsole
	{
		private StringBuilder _output;

		public TestConsole()
		{
			_output = new StringBuilder();
		}

		public string Output
		{
			get { return _output.ToString(); }
		}

		public string ReadLine()
		{
			return "5" + Environment.NewLine;
		}

		public void WriteLine(string s)
		{
			_output.AppendLine(s);
		}
	}

	
}
