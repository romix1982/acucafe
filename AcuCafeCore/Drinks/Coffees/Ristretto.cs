

namespace AcuCafeCore.Drinks.Coffees
{
    /// <summary>
    /// Ristretto drink class
    /// represent half Expresso
    /// </summary>
    public class Ristretto: IDrink
    {
        protected string Description = "Ristretto";
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
