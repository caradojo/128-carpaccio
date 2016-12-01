using System;
using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using NFluent;
using Xunit;
using _128_CarpaccioConsole;
using _128_CarpaccioModel;

namespace _128_CarpaccioFonctionnalTest
{
	public class CarpaccioConsoleProgramFonctionalTest
	{
		[Theory]
		[InlineData(100.00, 3)]
		public void buy_items_of_same_price_without_discount_for_uthah(double price, int count)
		{
			var consoleReadLine = new ConsoleReadLineForTest();
			var consoleWriteLine = new ConsoleWriteLineForTest();
			var carpaccioProgram = new CarpaccioConsoleProgram(consoleWriteLine, consoleReadLine);
			carpaccioProgram.Start();
	
			// when the user select couple of item / price
			consoleReadLine.PressEnter();

			// Then the order is count * price * 6.85 
			Check.That(consoleWriteLine.Output).EndsWith(string.Format("Total  {0:F}" + Environment.NewLine, price * count * 6.85));
		}
	}
}