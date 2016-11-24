using System;

namespace _128_CarpaccioModel
{
	public interface ICarpaccioEventAggregator
	{
		event EventHandler EventSubmitEvent;
	}
}