using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class OrderRepository
	{
		public Order Retrieve(int orderId)
		{
			// create the instance of the order and pass in the orderId
			Order order = new Order(orderId);

			// code that retrieves the defined order

			// temporary hard coded values to return a populated order
			if (orderId == 10)
			{
				order.OrderDate = new DateTimeOffset(2011, 06, 20, 07, 16, 39, new TimeSpan(1,0,0));
			}

			return new Order();
		}

		/// <summary>
		/// Saves the current customer.
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			// code that saves the defined order
			return true;
		}
	}
}
