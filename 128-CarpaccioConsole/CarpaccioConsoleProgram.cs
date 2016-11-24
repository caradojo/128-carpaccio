using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using _128_CarpaccioModel;

namespace _128_CarpaccioConsole
{
	public class CarpaccioConsoleProgram
	{
		private readonly IConsoleWriteLine _consoleWriteLine;
		private readonly IConsoleReadLine _consoleReadLine;
		private SubmitEvent _submitEvent;
		private CarpaccioProgram _carpaccioProgram;

		public CarpaccioConsoleProgram(IConsoleWriteLine consoleWriteLine, IConsoleReadLine consoleReadLine)
		{
			_consoleWriteLine = consoleWriteLine;
			_consoleReadLine = consoleReadLine;

			_consoleReadLine.NewLineEvent += OnNewLine;

			_submitEvent = new SubmitEvent();

			_carpaccioProgram = new CarpaccioProgram(new OrderService(_consoleWriteLine), _submitEvent);
		}

		public void Start()
		{			
			_consoleReadLine.Start();

			_consoleReadLine.Stop();
		}

		private void OnNewLine(object sender, string e)
		{
			_submitEvent.Publish();
		}
	}

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