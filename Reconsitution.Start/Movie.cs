using System;

namespace Reconsitution.Start
{
    class Movice
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; }
        public int PriceCode { get; set; }

        public Movice(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }
    }
}
