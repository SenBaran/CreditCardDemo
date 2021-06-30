using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Logic.UnitTest
{
    [TestClass]
    public class CreditcardUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Validate_SetNull_ThrowsArgumentException()
        {
            Controllers.Business.CreditcardLogic.CheckCreditcard(null);
        }
        [TestMethod]
        public void Validate_ToShortNumber_False()
        {
            var actual = Controllers.Business.CreditcardLogic.CheckCreditcard("1223435567");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_ToLongNumber_False()
        {
            var actual = Controllers.Business.CreditcardLogic.CheckCreditcard("12234355654545547983478957");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_OnlyDigit_True()
        {
            var actual = Controllers.Business.CreditcardLogic.CheckCreditcard("2718281828458567");
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_BeginWithLetter_False()
        {
            var actual = Controllers.Business.CreditcardLogic.CheckCreditcard("A223435567");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
