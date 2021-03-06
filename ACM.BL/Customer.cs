﻿using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL    // Acme Content Manager Buisiness Layer
{
	public class Customer : EntityBase, ILoggable
	{
		// default constructor -  VS will create automatically behind the sceens. Only make one if you need to add code to it or you need to create additional constructors. 
		public Customer() : this(0)	// calls the paramaterized constructer to initalize the the AddressList in order to avoid null exception
		{
			
		}

		public Customer(int customerId)	// since CustomerId setter is private, it cannot be access outside the class. Passed in here as a parameter to provide a way to set that property
		{
			this.CustomerId = customerId;
			AddressList = new List<Address>();
		}

		public List<Address> AddressList { get; set; }

		public int CustomerType { get; set; }
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
		
		// method to validate property values
		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;
		}

		public override string ToString()
		{
			return FullName;
		}

		public string Log()
		{
			var logString = this.CustomerId + ": " + this.FullName + ": " + "Email: " + this.EmailAddress.ToString();

			return logString;
		}
	}
}
