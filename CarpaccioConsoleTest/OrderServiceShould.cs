using FakeItEasy;
using Xunit;
using _128_CarpaccioConsole;
using _128_CarpaccioModel;

namespace CarpaccioConsoleTest
{
	public class OrderServiceShould
	{
		[Fact]
		public void write_total_order_in_console()
		{
			var consoleWriteLine = A.Fake<IConsoleWriteLine>();
			var orderService = new OrderService(consoleWriteLine);

			orderService.SendOrder(new [] {new Order(125.151)});

			A.CallTo(() => consoleWriteLine.WriteLine("Total: 125.15"));
		}
	}
}
