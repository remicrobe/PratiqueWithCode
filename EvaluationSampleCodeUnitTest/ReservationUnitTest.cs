using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTest
{

    [TestClass]
    public class ReservationUnitTest
    {
        private User _user = new User();
        private User _otherUser = new User();
        private User _adminUser = new User { IsAdmin=true };
        

        [TestMethod]
        public void MadeBy_WithIncorrectUser_ReturnFalse()
        {
            var reservation = new Reservation(_user);
            Assert.AreNotEqual(reservation.MadeBy, _adminUser);
        }

        [TestMethod]
        public void MadeBy_WithCorrectUser_AreEqual()
        {
            var reservation = new Reservation(_user);
            Assert.AreEqual(reservation.MadeBy, _user);
        }

        [TestMethod]
        public void CanBeCancelledBy_ByIncorrectUser_IsFalse()
        {
            var reservation = new Reservation(_user);
            Assert.IsFalse(reservation.CanBeCancelledBy(_otherUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_ByAdmin_IsTrue()
        {
            var reservation = new Reservation(_user);
            Assert.IsTrue(reservation.CanBeCancelledBy(_adminUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_ByUserMadeTheReservation_IsTrue()
        {
            var reservation = new Reservation(_user);
            Assert.IsTrue(reservation.CanBeCancelledBy(_user));
        }
    }
}
