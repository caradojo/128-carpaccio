namespace _128_CarpaccioModel
{
	public class Order
	{
		protected bool Equals(Order other)
		{
			return Amout.Equals(other.Amout);
		}

		public override int GetHashCode()
		{
			return Amout.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			var result = false;
			if (obj is Order)
			{
				result = Equals((Order) obj);
			}
			return result;
		}


		public Order(double amout)
		{
			Amout = amout;
		}

		public object Amout { get; private set; }
	}
}