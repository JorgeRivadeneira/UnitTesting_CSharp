using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja1st.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            
            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            //Assert.IsFalse(result);
            Assert.That(result, Is.False);
        }
    }
}