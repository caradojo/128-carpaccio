using System;

namespace _128_CarpaccioMsTest
{
	public interface IConsole
	{
		string ReadLine();
		void WriteLine(string s);
	}

	public class CarpaccioTermial
	{
		private readonly IConsole _console;

		public CarpaccioTermial(IConsole console)
		{
			_console = console;
		}

		public void DisplayQuantityQuestion()
		{
			_console.WriteLine("Entrez une quantit�");
		}

		public void AskAndDisplayQuantity()
		{
			string quantity = _console.ReadLine();
			_console.WriteLine(quantity.Replace(Environment.NewLine,""));
		}
	}
}