

namespace AcuCafeCore.Drinks.Tea
{
    /// <summary>
    /// Tea drink class
    /// </summary>
   public class Tea: IDrink
    {
        protected string Description = "Tea";
        protected double cost = 1.5;

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
