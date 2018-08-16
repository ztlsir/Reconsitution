using System;

namespace Refactoring.Start
{
    public class Rental
    {
        public Movie Movice { get; }
        public int DaysRented { get; }

        public Rental(Movie movice, int daysRented)
        {
            this.Movice = movice;
            this.DaysRented = daysRented;
        }

        public double GetCharge()
        {
            return this.Movice.GetCharge(this.DaysRented);
        }

        public int GetFrequentRenterPoints()
        {
            if ((this.Movice.PriceCode == Movie.NEW_RELEASE) &&
this.DaysRented > 1)
                return 2;
            else
                return 1;
        }
    }
}
