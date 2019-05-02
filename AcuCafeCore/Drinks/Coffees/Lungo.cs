

namespace AcuCafeCore.Drinks.Coffees
{
    /// <summary>
    /// Lungo drink class
    /// represent a double expresso
    /// </summary>
    public class Lungo: IDrink
    {
        protected string Description = "Lungo";
        protected double cost = 2;

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

