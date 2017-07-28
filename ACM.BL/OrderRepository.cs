using System;
using System.Collections.Generic;

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


		public OrderDisplay RetrieveOrderDisplay(int orderId)
		{
			OrderDisplay orderDisplay = new OrderDisplay();

			// Code that retrieves the defined order fields

			// Temporary hard coded data
			if (orderId == 10)
			{
				orderDisplay.FirstName = "Bilbo";
				orderDisplay.LastName = "Baggins";
				orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
				orderDisplay.ShippingAddress = new Address()
				{
					AddressType = 1,
					StreetLine1 = "Bag End",
					StreetLine2 = "Bagshot Row",
					City = "Hobbiton",
					State = "Shire",
					Country = "Middle Earth",
					PostalCode = "144"
				};
			}

			orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

			// Code that retrieves the order items

			// Temporary hard coded data
			if (orderId == 10)
			{
				var orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "Sunflowers",
					PurchasePrice = 15.96M,
					OrderQuantity = 2
				};
				orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

				orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "Rake",
					PurchasePrice = 6M,
					OrderQuantity = 1
				};
				orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
			}

			return orderDisplay;

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
