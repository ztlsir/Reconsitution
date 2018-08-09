using System;

namespace Reconsitution.Start
{
    class Rental
    {
        public Movice Movice { get; }
        public int DaysRented { get; }

        public Rental(Movice movice, int daysRented)
        {
            this.Movice = movice;
            this.DaysRented = daysRented;
        }
    }
}
