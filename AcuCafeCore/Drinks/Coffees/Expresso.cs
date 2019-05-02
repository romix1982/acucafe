

namespace AcuCafeCore.Drinks.Coffees
{
    /// <summary>
    /// Expresso Drink Class
    /// </summary>
    public class Expresso : IDrink
    {
        protected string Description = "Expresso";
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
