using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SmartNQuick.Logic.UnitTests
{
    [TestClass]
    public class BookLibraryBusinessTest
    {
        [TestMethod]
        public void Validate_SetNull_False()
        {
            var expected = false;
            var actual = Business.ISBNBusiness.validateISBN(null);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Validate_ToShortNumber_False()
        {
            var expected = false;
            var actual = Business.ISBNBusiness.validateISBN("1234");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_OnlyDigit_True()
        {
            var expected = true;
            var actual = Business.ISBNBusiness.validateISBN("1234567890");

            Assert.AreEqual(expected, actual);
        }
    }
}
