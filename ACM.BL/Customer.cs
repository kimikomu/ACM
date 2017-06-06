using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL	// Acme Content Manager Buisiness Layer
{
    public class Customer
    {	
		//static property
	    public static int InstanceCount { get; set; }

		// property added the long way using a field
		private string _lastName;
	    public string LastName
	    {
		    get { return _lastName; }
		    set { _lastName = value; }
	    }

		// auto-implementing properties have backing fields built into them
		public string FirstName { get; set; }

	    public string EmailAddress { get; set; }

	    public int CustomerId { get; private set; }

	    // does not need a backing field bc it does not require storage of any data. No way to set anything, making it readonly
		public string FullName		
	    {
		    get
		    {
			    string fullName = LastName;
			    if (!string.IsNullOrWhiteSpace(FirstName))
			    {
				    if (!string.IsNullOrWhiteSpace(fullName))
				    {
					    fullName += ", ";
				    }
				    fullName += FirstName;
			    }
				return fullName;
		    }	
	    }

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
		
		// method to validate property values
	    public bool Validate()
	    {
		    var isValid = true;

		    if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
		    if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

		    return isValid;
	    }
		
	}
}
