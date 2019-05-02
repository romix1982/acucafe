

namespace AcuCafeCore
{
    /// <summary>
    /// Add sugar 
    /// </summary>
    public class SugarDecorator: AddinDecorator
    {
        public SugarDecorator(IDrink drink)
        : base(drink)
        {
            addInName = "Sugar";
            addInPrice = 0.5;
        }

    }
}
