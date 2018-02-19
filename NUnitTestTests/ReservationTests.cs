using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Tests
{
    [TestClass()]
    public class ReservationTests
    {
        [TestMethod()]
        public void CanBeCancelledByTest()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod()]
        public void CanBeCancelledByTest_SomethingElse()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }


    }
}