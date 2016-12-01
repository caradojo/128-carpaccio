using System.Collections.Generic;
using _128_CarpaccioModel;

namespace _128_CarpaccioConsole
{
	public class OrderService : IOrderService
	{
		private readonly IConsoleWriteLine _consoleWriteLine;

		public OrderService(IConsoleWriteLine consoleWriteLine)
		{
			_consoleWriteLine = consoleWriteLine;
		}

		public void SendOrder(IEnumerable<Order> orders)
		{
			foreach (var order in orders)
			{
				_consoleWriteLine.WriteLine(string.Format("Total  {0:F}", order.Amout));
			}
		}
	}
}		