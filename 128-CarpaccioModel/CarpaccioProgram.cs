using System;

namespace _128_CarpaccioModel
{
	public class CarpaccioProgram
	{
		private readonly IOrderService _orderService;

		public CarpaccioProgram(IOrderService orderService)
		{
			_orderService = orderService;
		}

		public void Submit()
		{
			_orderService.SendOrder(new Order[] {new Order(300*6.85)});
		}
	}
}