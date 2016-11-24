using NFluent;
using Xunit;
using _128_CarpaccioModel;

namespace _128_CarpaccioMsTest
{
	public class CarpaccioEvetAggregatorShould
	{
		[Fact]
		public void raise_submit_event_when_publish_submit()
		{
			var carpaccioEvetAggregator = new CarpaccioEvetAggregator();
			int count = 0;
			carpaccioEvetAggregator.SubmitEvent += (sender, args) => count++;

			carpaccioEvetAggregator.PublishSubmit();

			Check.That(count).Equals(1);
		}
	}
}
