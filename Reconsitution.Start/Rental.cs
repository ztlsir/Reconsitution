using System;

namespace Reconsitution.Start
{
    class Rental
    {
        private Movice Movice { get; }
        private int DaysRented { get; }

        public Rental(Movice movice, int daysRented)
        {
            this.Movice = movice;
            this.DaysRented = daysRented;
        }
    }
}
