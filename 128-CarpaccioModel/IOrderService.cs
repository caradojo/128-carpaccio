using System.Collections.Generic;

namespace _128_CarpaccioModel
{
	public interface IOrderService
	{
		void SendOrder(IEnumerable<Order> orders);
	}
}