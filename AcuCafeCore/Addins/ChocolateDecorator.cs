

namespace AcuCafeCore
{
    /// <summary>
    /// Add Chocolate
    /// </summary>
    public class ChocolateDecorator: AddinDecorator
    {
        public ChocolateDecorator(IDrink drink)
        : base(drink)
        {
            addInName = "Chocolate";
            addInPrice = 0.5;
        }
    }
}
