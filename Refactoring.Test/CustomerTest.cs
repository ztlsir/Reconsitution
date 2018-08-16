using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Start;

namespace Refactoring.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Verify_add_a_customer()
        {
            string movieName = "一出好戏";
            int movieType = Movie.NEW_RELEASE;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;
            Rental rental = new Rental(movie, daysRented);
            string customerName = "john";
            string statementResult=string.Format("Rental Record for {0}\n\t{1}\t{2}\nAmount owed is {3}\nYou earned {4} frequent renter points",
            customerName,movieName,daysRented*3,daysRented*3,2);

            Customer customer = new Customer(customerName);
            customer.AddRental(rental);

            Assert.AreEqual(movieName, rental.Movice.Title);
            Assert.AreEqual(movieType, rental.Movice.PriceCode);
            Assert.AreEqual(daysRented, rental.DaysRented);
            Assert.AreEqual(customerName, customer.Name);
            Assert.IsNotNull(customer.Statement());
            Assert.AreEqual(statementResult, customer.Statement());
        }
    }
}
