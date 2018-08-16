using System;

namespace Refactoring.Start
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; }
        private Price price;
        public int PriceCode
        {
            get
            {
                return price.GetPriceCode();
            }
            set
            {
                switch (value)
                {
                    case Movie.REGULAR:
                        price = new RegularPrice();
                        break;
                    case Movie.NEW_RELEASE:
                        price = new NewReleasePrice();
                        break;
                    case Movie.CHILDRENS:
                        price = new ChildrensPrice();
                        break;
                    default:
                        throw new ArgumentException("Incorrect Price Code");
                }
            }
        }

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }

        public double GetCharge(int daysRented)
        {
            return this.price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            if ((this.PriceCode == Movie.NEW_RELEASE) && daysRented > 1)
                return 2;
            else
                return 1;
        }
    }
}
