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
            return this.Movice.GetFrequentRenterPoints(this.DaysRented);
        }
    }
}
