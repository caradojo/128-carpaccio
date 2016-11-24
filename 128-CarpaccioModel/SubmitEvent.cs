using System;

namespace _128_CarpaccioModel
{
	public class SubmitEvent : ICarpaccioEventAggregator
	{
		public event EventHandler Event;

		public void Publish()
		{
			if (Event != null)
			{
				Event(this, EventArgs.Empty);
			}
		}
	}
}