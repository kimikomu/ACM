﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
	public class Order
	{
		public Order()
		{
				
		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		public int CustomerId { get; set; }
		public int ShippingAddressId { get; set; }

		public DateTimeOffset? OrderDate { get; set; }  // DateTimeOffset holds date, time, and time zone offset
		public int OrderId { get; private set; }
		public List<OrderItem> orderItems { get; set; }

		// method to validate property values
		public bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}
	}
}
