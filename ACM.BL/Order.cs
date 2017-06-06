using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	class Order
	{
		public Order()
		{
				
		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		public DateTimeOffset? OrderDate { get; set; }  // can hold value of DateTimeOffset OR null	// DateTimeOffset holds date, time, and time zone offset
		public int OrderId { get; private set; }

		public Order Retrieve(int orderId)
		{
			// code that retrieves the defined customer
			return new Order();
		}

		/// <summary>
		/// Saves the current customer.
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			// code that saves the defined customer
			return true;
		}

		// method to validate property values
		public bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}
	}
}
