using System;
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

		[TestMethod]
		public void Print_ask_for_price_at_init()
		{
			var testConsole = new TestConsole();

			var terminal = new CarpaccioTermial(testConsole);
			terminal.DisplayPriceQuestion();

			Assert.AreEqual("Entrez un prix" + Environment.NewLine,
				testConsole.Output);
		}

		[TestMethod]
		public void Echo_price_input_at_init()
		{
			var testConsole = new TestConsole();

			var terminal = new CarpaccioTermial(testConsole);
			terminal.AskAndDisplayPrice();

			Assert.AreEqual("5" + Environment.NewLine,
				testConsole.Output);
		}
		
		[TestMethod]
		public void dipslay_a_given_total()
		{
			var testConsole = new TestConsole();

			var terminal = new CarpaccioTermial(testConsole);
			terminal.DisplayTotal(52);

			Assert.AreEqual("Total : 52,00 €" + Environment.NewLine,
				testConsole.Output);
		}
	}
}