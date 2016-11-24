using Xunit;
using NFluent;

namespace _128_CarpaccioFonctionnalTest
{
    public class Class1
    {

	    [Theory]
		[InlineData(100.00, 3)]
	    public void buy_items_of_same_price_without_discount_for_uthah(double price, int count)
	    {
		    var carpaccioProgram = new CarpaccioProgram();
		    // when the user select couple of item / price


			// Then the order is count * price * 6.85 
		    var order = new Order(0);
		    Check.That(order).Equals(new Order(price*count));
	    }
    }

}
