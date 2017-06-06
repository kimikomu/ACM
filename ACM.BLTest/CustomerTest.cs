using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{

	// one method for each test you want to perform
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]		// tests valid condition
		public void FullNameTestValid()
		{
			//-- Arrange - set up the test
			Customer customer = new Customer();
			customer.FirstName = "Bilbo";
			customer.LastName = "Baggins";

			string expected = "Baggins, Bilbo";		// the value we are expecting to get back from Customer

			//-- Act - perform the opperation that we are testing.
			string actual = customer.FullName;

			//--Assert - verifies that the expected value matches the actual value
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]        // tests invalid condition
		public void FullFirstNameEmpty()
		{
			//-- Arrange
			Customer customer = new Customer();
			customer.LastName = "Baggins";
			string expected = "Baggins";     

			//-- Act
			string actual = customer.FullName;

			//--Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]        // tests invalid condition
		public void FullLastNameEmpty()
		{
			//-- Arrange
			Customer customer = new Customer();
			customer.FirstName = "Bilbo";
			string expected = "Bilbo";

			//-- Act
			string actual = customer.FullName;

			//--Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]        // static test
		public void StaticTest()
		{
			//-- Arrange
			var c1 = new Customer();
			c1.FirstName = "Bilbo";
			Customer.InstanceCount += 1;	// InstanceCount is static and so must be referenced through the class itself, not an instance of the class

			var c2 = new Customer();
			c2.FirstName = "Frodo";
			Customer.InstanceCount += 1;

			var c3 = new Customer();
			c3.FirstName = "Rosie";
			Customer.InstanceCount += 1;

			//-- Act

			//--Assert
			Assert.AreEqual(3, Customer.InstanceCount);
		}


	}
}
