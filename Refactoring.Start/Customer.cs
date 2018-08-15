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

                thisAmount = each.GetCharge();

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
    }
}
