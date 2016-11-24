using System;
using System.Threading.Tasks;

namespace _128_CarpaccioConsole
{
	internal class ConsoleReadLineAdapter : IConsoleReadLine
	{
		private bool _stopRequired;
		private Task _task;
		public event EventHandler<string> NewLineEvent;
		public void Start()
		{
			_task = Task.Run(new Action(ReadLoop));
		}

		private void ReadLoop()
		{
			var line = Console.ReadLine();
			if (NewLineEvent != null) 
				NewLineEvent(this, line);
		}

		public void Stop()
		{
			_stopRequired = true;
			_task.Wait();
		}
	}
}