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
        public void Verify_a_rental_charge()
        {
            string movieName = "一出好戏";
            int movieType = Movie.NEW_RELEASE;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;

            var rental = new Rental(movie, daysRented);
            
            Assert.AreEqual(30, rental.GetCharge());
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
