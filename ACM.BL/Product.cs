﻿using System;
using Acme.Common;

namespace ACM.BL
{
	public class Product : EntityBase, ILoggable
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

		private String _ProductName;

		public String ProductName
		{
			get
			{
				return _ProductName.InsertSpaces();
			}
			set { _ProductName = value; }
		}


		// method to validate property values
		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}

		public override string ToString()
		{
			return ProductName;
		}

		public string Log()
		{
			var logString = this.ProductId + ": " + this.ProductName + " " + "Detail: " + this.ProductDescription.ToString();

			return logString;
		}

	}
}
