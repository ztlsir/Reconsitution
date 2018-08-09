using System;

namespace Reconsitution.Start
{
    class Movice
    {
        public static readonly int CHILDRENS = 2;
        public static readonly int REGULAR = 0;
        public static readonly int NEW_RELEASE = 1;

        public string Title { get; }
        public int PriceCode { get; set; }

        public Movice(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }
    }
}
