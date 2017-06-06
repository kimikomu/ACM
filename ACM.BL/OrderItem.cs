using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	class OrderItem
	{
		public OrderItem()
		{
			
		}

		public OrderItem(int orderItemId)
		{
			this.OrderItemId = orderItemId;
		}

		public int OrderItemId { get; private set; }
		public int OrderQuantity { get; set; }
		public int ProductId { get; set; }
		public decimal? PurchasePrice { get; set; }

		public OrderItem Retrieve(int orderItemId)
		{
			// code that retrieves the defined order item
			return new OrderItem();
		}

		/// <summary>
		/// Saves the current customer.
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			// code that saves the defined order item
			return true;
		}

		// method to validate property values
		public bool Validate()
		{
			var isValid = true;

			if (OrderQuantity <= 0) isValid = false;
			if (ProductId <= 0) isValid = false;
			if (PurchasePrice == null) isValid = false;

			return isValid;
		}

	}
}
