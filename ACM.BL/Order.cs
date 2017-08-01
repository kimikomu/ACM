﻿using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
	public class Order : EntityBase, ILoggable
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
		public override bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}

		public override string ToString()
		{
			return OrderDate.Value.Date + " ( " + OrderId + ")";
		}

		public string Log()
		{
			var logString = this.OrderId + ": " + "Date: " + this.OrderDate.ToString();

			return logString;
		}
	}
}
