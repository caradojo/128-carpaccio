using System;

namespace _128_CarpaccioModel
{
	public class CarpaccioProgram
	{
		private readonly IOrderService _orderService;

		public CarpaccioProgram(IOrderService orderService, ICarpaccioEventAggregator carpaccioEventAggregator)
		{
			_orderService = orderService;
			carpaccioEventAggregator.SubmitEvent += OnSubmit;
		}

		private void OnSubmit(object sender, EventArgs e)
		{
			_orderService.SendOrder(new Order[]{ new Order(0.0) });
		}
	}
}