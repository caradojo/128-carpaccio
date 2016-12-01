using FakeItEasy;
using Xunit;
using _128_CarpaccioConsole;

namespace CarpaccioConsoleTest
{
    public class CarpaccioConsoleProgramShould
    {
	    [Fact]
	    public void start_console_reader()
	    {
		    var consoleReadLine = A.Fake<IConsoleReadLine>();
		    var consoleProgram = new CarpaccioConsoleProgram(A.Fake<IConsoleWriteLine>(), consoleReadLine);

		    consoleProgram.Start();

		    A.CallTo( () => consoleReadLine.Start()).MustHaveHappened(Repeated.Exactly.Once);
	    }

		[Fact]
		public void stop_console_reader()
		{
			var consoleReadLine = A.Fake<IConsoleReadLine>();
			var consoleProgram = new CarpaccioConsoleProgram(A.Fake<IConsoleWriteLine>(), consoleReadLine);

			consoleProgram.Start();

			A.CallTo(() => consoleReadLine.Stop()).MustHaveHappened(Repeated.Exactly.Once);
		}
    }
}
