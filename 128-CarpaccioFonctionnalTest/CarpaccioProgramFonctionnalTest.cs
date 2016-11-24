﻿using System.Collections.Generic;
using FakeItEasy;
using Xunit;
using NFluent;
using _128_CarpaccioModel;

namespace _128_CarpaccioFonctionnalTest
{
	public class CarpaccioProgramFonctionnalTest
    {

	    [Theory]
		[InlineData(100.00, 3)]
	    public void buy_items_of_same_price_without_discount_for_uthah(double price, int count)
	    {
		    var orderRepository = A.Fake<IOrderService>();
		    IEnumerable<Order> orders = null;
		    A.CallTo(() => orderRepository.SendOrder(A<IEnumerable<Order>>.Ignored)).Invokes(s => orders = s.GetArgument<IEnumerable<Order>>(0));

		    var carpaccioProgram = new CarpaccioProgram();
		    // when the user select couple of item / price


			// Then the order is count * price * 6.85 
		    var order = new Order(0);
		    Check.That(order).Equals(new Order(price*count));
	    }
    }
}