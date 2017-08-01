﻿using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
	[TestClass]
	public class StringHandlerTest
	{
		[TestMethod]
		public void InsertSpaceTestValid()
		{
			//-- Arrange
			var source = "SonicScrewdriver";
			var expected = "Sonic Screwdriver";


			//-- Act
			var actual = StringHandler.InsertSpaces(source);

			//-- Assert
			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void InsertSpacesTestWithExistingSpace()
		{
			//-- Arrange
			var source = "Sonic Screwdriver";
			var expected = "Sonic Screwdriver";


			//-- Act
			var actual = StringHandler.InsertSpaces(source);

			//-- Assert
			Assert.AreEqual(actual, expected);
		}
	}
}
