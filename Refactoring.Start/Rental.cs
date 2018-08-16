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
            double result = 0;
            //determine amounts for each line
            switch (this.Movice.PriceCode)
            {
                case Movie.REGULAR:
                    result += 2;
                    if (this.DaysRented > 2)
                        result += (this.DaysRented - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    result += this.DaysRented * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (this.DaysRented > 3)
                        result += (this.DaysRented - 3) * 1.5;
                    break;
            }

            return result;
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
