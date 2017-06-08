using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public bool Save()
		{
			// code that saves the defined product
			return true;
		}
	}
}
