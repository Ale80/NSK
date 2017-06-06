namespace Nsk.Web.Site
{
    public static class Utilities
    {
        public static decimal GetDiscountedPrice(decimal price)
        {
			return price * 90 / 100;
        }
    }
}