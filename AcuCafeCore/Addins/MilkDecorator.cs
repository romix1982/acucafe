

namespace AcuCafeCore
{
    /// <summary>
    /// Add Milk
    /// </summary>
    public class MilkDecorator: AddinDecorator
    {
        public MilkDecorator(IDrink drink)
        : base(drink)
        {
            addInName = "Milk";
            addInPrice = 0.5;
        }
    }
}
