using System;

namespace ACM.BL
{
	public class ProductRepository
	{
		/// <summary>
		/// Retrieve one product.
		/// </summary>
		public Product Retrieve(int productId)
		{
			// create the instance of the Product class and pass in the requested id
			Product product = new Product(productId);

			// code that retrieves the defined product
			Object myObject = new Object();

			Console.WriteLine("Object: " + myObject.ToString());
			Console.WriteLine("Product: " + product.ToString());

			// temporary hard coded values to return a populated product
			if (productId == 2)
			{
				product.ProductName = "Sunflowers";
				product.ProductDescription = "Assorted Sizes";
				product.CurrentPrice = 15.96M;
			}

			return product;
		}

		/// <summary>
		/// Saves the current product.
		/// </summary>
		/// <returns></returns>
		public bool Save(Product product)
		{
			var success = true;

			if (product.HasChanges && product.IsValid)
			{
				if (product.IsNew)
				{
					// Call an Insert Stored Procedure
				}
				else
				{
					// Call an Update Stored Procedure
				}
			}
			return success;
		}
	}
}
