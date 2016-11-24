using NFluent;
using Xunit;
using _128_CarpaccioModel;

namespace _128_CarpaccioMsTest
{
	public class SubmitEventShould
	{
		[Fact]
		public void raise_submit_event_when_publish_submit()
		{
			var carpaccioEvetAggregator = new SubmitEvent();
			int count = 0;
			carpaccioEvetAggregator.Event += (sender, args) => count++;

			carpaccioEvetAggregator.Publish();

			Check.That(count).Equals(1);
		}
	}
}
