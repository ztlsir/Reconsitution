namespace Refactoring.Start
{
    public class ChildrensPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }
    }
}