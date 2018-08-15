using System;
using System.Collections;
using System.Collections.Generic;

namespace Refactoring.Start
{
    public class Customer
    {
        public string Name { get; }
        private ArrayList Rentals = ArrayList.Synchronized(new ArrayList());

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + this.Name + "\n";

            foreach (Rental each in Rentals)
            {
                double thisAmount = 0;

                thisAmount = AmountFor(each);

                //add frequent renter points
                frequentRenterPoints++;
                //add bonus for a two day new release rental
                if ((each.Movice.PriceCode == Movie.NEW_RELEASE) &&
                each.DaysRented > 1) frequentRenterPoints++;

                //show figures for this rental
                result += "\t" + each.Movice.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }
            //add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";
            return result;
        }

        private static double AmountFor(Rental aRental)
        {
            double result = 0;
            //determine amounts for each line
            switch (aRental.Movice.PriceCode)
            {
                case Movie.REGULAR:
                    result += 2;
                    if (aRental.DaysRented > 2)
                        result += (aRental.DaysRented - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    result += aRental.DaysRented * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (aRental.DaysRented > 3)
                        result += (aRental.DaysRented - 3) * 1.5;
                    break;
            }

            return result;
        }
    }
}
