namespace _128_CarpaccioModel
{
	public class Order
	{
		protected bool Equals(Order other)
		{
			return _amout.Equals(other._amout);
		}

		public override int GetHashCode()
		{
			return _amout.GetHashCode();
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

		private readonly double _amout;

		public Order(double amout)
		{
			_amout = amout;
		}
	}
}