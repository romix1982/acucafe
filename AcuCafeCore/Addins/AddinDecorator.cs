

namespace AcuCafeCore
{
    /// <summary>
    /// abstract AddIn Decorator class
    /// implement IDrink
    /// </summary>
    public abstract class AddinDecorator : IDrink
    {
        IDrink oDrink;

        protected string addInName;
        protected double addInPrice;


        public AddinDecorator(IDrink pDrink)
        {
            oDrink = pDrink;
        }

        public double Cost()
        {
            return oDrink.Cost() + addInPrice;
        }

        public string Prepare()
        {
            return string.Format("{0}, {1}", oDrink.Prepare(), addInName);
        }
    }
}
