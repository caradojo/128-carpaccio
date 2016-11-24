using System;

namespace _128_CarpaccioModel
{
	public class CarpaccioEvetAggregator : ICarpaccioEventAggregator
	{
		public event EventHandler SubmitEvent;

		public void PublishSubmit()
		{
			if (SubmitEvent != null)
			{
				SubmitEvent(this, EventArgs.Empty);
			}
		}
	}
}