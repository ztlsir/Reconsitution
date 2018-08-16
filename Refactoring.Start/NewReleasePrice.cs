namespace Refactoring.Start
{
    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }
    }
}