using AcuCafeCore.Drinks.Coffees;
using System;


namespace AcuCafeCore.Factories
{
    /// <summary>
    /// Coffee Factory
    /// </summary>
    public class CoffeeFactory : AbstractAcuCafeFactory
    {
        /// <summary>
        /// Generates a base Coffee drink ordered
        /// </summary>
        /// <param name="drinkDescription"></param>
        /// <returns></returns>
        public override IDrink GetDrink(AcuCafeEnum.EnumDrinks drinkDescription)
        {
            IDrink oDrink;
            try
            {                
                switch (drinkDescription)
                {
                    case AcuCafeEnum.EnumDrinks.EXPRESSO:
                        oDrink = new Expresso();
                        break;
                    case AcuCafeEnum.EnumDrinks.RISTRETTO:
                        oDrink = new Ristretto();
                        break;
                    case AcuCafeEnum.EnumDrinks.LUNGO:
                        oDrink = new Lungo();
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
