using System.Collections.Generic;
using FakeItEasy;
using Xunit;
using _128_CarpaccioModel;

namespace _128_CarpaccioMsTest
{
	public class CarpaccioProgramShould
	{
		[Fact]
		public void send_order_when_submit()
		{
			var orderRepository = A.Fake<IOrderService>();
			var carpaccioProgram = new CarpaccioProgram(orderRepository);

			carpaccioProgram.Submit();

			A.CallTo(() => orderRepository.SendOrder(A<IEnumerable<Order>>.Ignored)).MustHaveHappened(Repeated.Exactly.Once);
		}
	}


}
