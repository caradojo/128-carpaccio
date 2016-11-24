namespace _128_CarpaccioModel
{
	public class CarpaccioProgram
	{
		private readonly IOrderService _orderRepository;

		public CarpaccioProgram(IOrderService orderRepository)
		{
			_orderRepository = orderRepository;
			throw new System.NotImplementedException();
		}
	}
}