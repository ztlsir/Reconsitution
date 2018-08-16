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

        [TestMethod]
        public void Verify_a_rental_charge_with_new_release()
        {
            string movieName = "一出好戏";
            int movieType = Movie.NEW_RELEASE;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(30, rental.GetCharge());
        }

        [TestMethod]
        public void Verify_a_rental_charge_with_childrens()
        {
            string movieName = "麦兜响当当";
            int movieType = Movie.CHILDRENS;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 5;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(4.5, rental.GetCharge());
        }

        [TestMethod]
        public void Verify_a_rental_charge_with_regular()
        {
            string movieName = "男儿本色";
            int movieType = Movie.REGULAR;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 7;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(9.5, rental.GetCharge());
        }

        [TestMethod]
        public void Verify_rental_new_release_points()
        {
            string movieName = "一出好戏";
            int movieType = Movie.NEW_RELEASE;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(2, rental.GetFrequentRenterPoints());
        }

        [TestMethod]
        public void Verify_rental_not_new_release_points()
        {
            string movieName = "杀生";
            int movieType = Movie.REGULAR;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;

            var rental = new Rental(movie, daysRented);

            Assert.AreEqual(1, rental.GetFrequentRenterPoints());
        }
    }
}
