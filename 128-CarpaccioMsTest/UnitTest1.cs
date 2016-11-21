using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _128_CarpaccioMsTest
{
	[TestClass]
	public class CarpaccioTermialShould
	{
		[TestMethod]
		public void Print_ask_for_qantity_at_init()
		{
			var testConsole = new TestConsole();

			var terminal = new CarpaccioTermial(testConsole);
			terminal.DisplayQuantityQuestion();

			Assert.AreEqual("Entrez une quantité" + Environment.NewLine,
				testConsole.Output);
		}

		[TestMethod]
		public void Echo_qantity_input_at_init()
		{
			var testConsole = new TestConsole();

			var terminal = new CarpaccioTermial(testConsole);
			terminal.AskAndDisplayQuantity();

			Assert.AreEqual("5" + Environment.NewLine,
				testConsole.Output);
		}
	}


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
