using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Start;

namespace Refactoring.Test
{
    [TestClass]
    public class RentalTest
    {
        [TestMethod]
        public void Verify_add_a_rental()
        {
            string movieName = "一出好戏";
            int movieType = Movie.CHILDRENS;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(movieName, rental.Movice.Title);
            Assert.AreEqual(movieType, rental.Movice.PriceCode);
            Assert.AreEqual(daysRented, rental.DaysRented);
        }
    }
}
