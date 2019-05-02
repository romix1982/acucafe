

namespace AcuCafeCore.Drinks.Tea
{
    /// <summary>
    /// IceTea Drink Class
    /// </summary>
    public class IceTea : IDrink
    {
        protected string Description = "IceTea";
        protected double cost = 1.8;

        public double Cost()
        {
            return cost;
        }

        public string Prepare()
        {
            return Description;
        }
    }
}
