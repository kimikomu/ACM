using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class Product
	{
		public Product()
		{
			
		}

		public Product(int productId)
		{
			this.ProductId = productId;
		}

		public Decimal? CurrentPrice { get; set; }	// nullable type is a value type (int, decimal) allows definition of a value OR a null. Use when the code needs to distinguish between "not set" and 0;
		public int ProductId { get; private set; }
		public string ProductDescription { get; set; }
		public string ProductName { get; set; }

		// method to validate property values
		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}
	}
}
