using _128_CarpaccioModel;

namespace _128_CarpaccioConsole
{
	public class CarpaccioConsoleProgram
	{
		private readonly IConsoleWriteLine _consoleWriteLine;
		private readonly IConsoleReadLine _consoleReadLine;
		private CarpaccioProgram _carpaccioProgram;

		public CarpaccioConsoleProgram(IConsoleWriteLine consoleWriteLine, IConsoleReadLine consoleReadLine)
		{
			_consoleWriteLine = consoleWriteLine;
			_consoleReadLine = consoleReadLine;

			_consoleReadLine.NewLineEvent += OnNewLine;

			_carpaccioProgram = new CarpaccioProgram(new OrderService(_consoleWriteLine));
		}

		public void Start()
		{			
			_consoleReadLine.Start();

			_consoleReadLine.Stop();
		}

		private void OnNewLine(object sender, string e)
		{
			_carpaccioProgram.Submit();
		}
	}
}