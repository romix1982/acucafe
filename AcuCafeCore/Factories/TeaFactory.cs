using AcuCafeCore.Drinks.Tea;
using System;


namespace AcuCafeCore.Factories
{
    /// <summary>
    /// Generate a Tea base drink ordered
    /// </summary>
    public class TeaFactory : AbstractAcuCafeFactory
    {
        public override IDrink GetDrink(AcuCafeEnum.EnumDrinks drinkDescription)
        {
            IDrink oDrink;
            try
            {
                switch (drinkDescription)
                {
                    case AcuCafeEnum.EnumDrinks.TEA:
                        oDrink = new Tea();
                        break;
                    case AcuCafeEnum.EnumDrinks.ICETEA:
                        oDrink = new IceTea();
                        break;
                    default:
                        throw new Exception("Undefine Drink. We can not manage the order.");
                }
                return oDrink;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
