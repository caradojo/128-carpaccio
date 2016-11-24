using System;
using _128_CarpaccioConsole;

namespace _128_CarpaccioFonctionnalTest
{
	public class ConsoleReadLineForTest : IConsoleReadLine
	{
		public void PressEnter()
		{
			if (NewLineEvent != null) 
				NewLineEvent(this, "");
		}

		public event EventHandler<string> NewLineEvent;
		public void Start()
		{			
		}

		public void Stop()
		{
			
		}
	}
}