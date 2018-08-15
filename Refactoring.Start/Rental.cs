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
    }
}
