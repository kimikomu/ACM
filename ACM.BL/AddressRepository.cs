﻿using System.Collections.Generic;

namespace ACM.BL
{
	class AddressRepository
	{
		/// <summary>
		/// Retrieve one address
		/// </summary>

		public Address Retrieve(int addressId)
		{
			// Create the instance of the address class
			// Pass in the requested Id
			Address address = new Address(addressId);

			// Code that retrieves the defined address

			// Temporary hard coded values to return a populated address
			if (addressId == 1)
			{
				address.StreetLine1 = "Bag End";
				address.StreetLine2 = "Bagshot Row";
				address.City = "Hobbiton";
				address.State = "Shire";
				address.Country = "Middle Earth";
				address.PostalCode = "144";
			}

			return address;
		}

		public IEnumerable<Address> RetrieveByCustomerId(int customerId)
		{
			// Code that retrieves the defined addresses for the customer

			// Temporary hard coded values to return a set of addresses for a customer
			var addressList = new List<Address>();
			Address address = new Address(1)
			{
				AddressType = 1,
				StreetLine1 = "Bag End",
				StreetLine2 = "Bagshot Row",
				City = "Hobbiton",
				State = "Shire",
				Country = "Middle Earth",
				PostalCode = "144"
			};
			addressList.Add(address);

			address = new Address(2)
			{
				AddressType = 2,
				StreetLine1 = "Green Dragon",
				StreetLine2 = "Bywater",
				City = "Shire",
				Country = "Middle Earth",
				PostalCode = "146"
			};
			addressList.Add(address);

			return addressList;
		}

		/// <summary>
		/// Saves the current address
		/// </summary>
		/// <returns></returns>
		public bool Save(Address address)
		{
			// Code that saves the defined address

			return true;
		}
	}
}