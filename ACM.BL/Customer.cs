using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL	// Acme Content Manager Buisiness Layer
{
    public class Customer
    {
	    private string _lastName;

	    public string LastName
	    {
		    get { return _lastName; }
		    set { _lastName = value; }
	    }

		public string FirstName { get; set; }

	    public string EmailAddress { get; set; }

	    public int CustomerId { get; private set; }

	    public string FullName		// does not need a backing field bc it does not require storage of any data
	    {
		    get { return LastName + "," + FirstName; }	
	    }
	}
}
