using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class CustomerRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		public Customer Retrieve(int customerId)
		{
			// create the instance of the customer class
			Customer customer = new Customer(customerId);		// customerId can be set at instantiation of the object only

			// code that retrieves the defined customer
			
			// temporary hard coded values to return a populated customer
			if (customerId == 1)
			{
				customer.EmailAddress = "fbaggins@hobbiton.me";
				customer.FirstName = "Frodo";
				customer.LastName = "Baggins";
			}
			return customer;
		}

		/// <summary>
		/// Retrieve
		/// </summary>
		public List<Customer> Retrieve()
		{
			// code that retrieves the defined customer
			return new List<Customer>();
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
	}
}
