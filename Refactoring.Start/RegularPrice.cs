namespace Refactoring.Start
{
    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }
    }
}