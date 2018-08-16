using System;
using System.Collections;
using System.Collections.Generic;

namespace Refactoring.Start
{
    public class Customer
    {
        public string Name { get; }
        private ArrayList rentals = ArrayList.Synchronized(new ArrayList());

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string Statement()
        {
            string result = "Rental Record for " + this.Name + "\n";

            foreach (Rental each in rentals)
            {
                //show figures for this rental
                result += "\t" + each.Movice.Title + "\t" +
                 each.GetCharge().ToString() + "\n";
            }

            //add footer lines
            result += "Amount owed is " + this.GetTotalCharge().ToString() + "\n";
            result += "You earned " + this.GetTotalFrequentRenterPoints().ToString() +
             " frequent renter points";
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
            foreach (Rental each in this.rentals)
            {
                result += each.GetCharge();
            }
            return result;
        }

        private double GetTotalFrequentRenterPoints()
        {
            int result = 0;
            foreach (Rental each in this.rentals)
            {
                result += each.GetFrequentRenterPoints();
            }
            return result;
        }
    }
}
