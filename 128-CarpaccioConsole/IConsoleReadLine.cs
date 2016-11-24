using System;

namespace _128_CarpaccioConsole
{
	public interface IConsoleReadLine
	{
		event EventHandler<string> NewLineEvent;
		void Start();
		void Stop();
	}
}