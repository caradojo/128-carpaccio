using System;
using System.Collections;
using System.Collections.Generic;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using _128_CarpaccioFonctionnalTest;
using _128_CarpaccioModel;

namespace _128_CarpaccioMsTest
{
	public class CarpaccioProgramShould
	{
		[Fact]
		public void send_order_when_submit_event_is_raised()
		{
			var orderRepository = A.Fake<IOrderService>();
			var carpaccioEventAggregator = A.Fake<ICarpaccioEventAggregator>();
			var carpaccioProgram = new CarpaccioProgram(orderRepository, carpaccioEventAggregator);

			carpaccioEventAggregator.SubmitEvent += Raise.WithEmpty().Now;

			A.CallTo(() => orderRepository.SendOrder(A<IEnumerable<Order>>.Ignored)).MustHaveHappened(Repeated.Exactly.Once);
		}
	}


}
