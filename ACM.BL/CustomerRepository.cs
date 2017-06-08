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
			// code that retrieves the defined customer
			return new Customer();
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
