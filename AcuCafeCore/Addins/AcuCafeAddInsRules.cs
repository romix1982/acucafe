using AcuCafeCore.Drinks.Tea;
using System;


namespace AcuCafeCore.Addins
{
    /// <summary>
    /// AddIns Manager class
    /// </summary>
    public class AcuCafeAddInsRules
    {

        /// <summary>
        /// Manages the coffee addIns
        /// </summary>
        /// <param name="drinkOrder"></param>
        /// <param name="hasMilk"></param>
        /// <param name="hasSugar"></param>
        /// <param name="hasChocolate"></param>
        /// <returns>IDrink</returns>
        public static IDrink ProcessCoofeeAddIns(IDrink drinkOrder, bool hasMilk, bool hasSugar, bool hasChocolate)
        {
            try
            {
                IDrink fullDrink;
                //in this case every coffee allow every addIns
                if (hasMilk && hasSugar && hasChocolate)
                    return fullDrink = new MilkDecorator(new SugarDecorator(new ChocolateDecorator(drinkOrder)));
                else if (!hasMilk && hasSugar && hasChocolate)
                    return fullDrink = new SugarDecorator(new ChocolateDecorator(drinkOrder));
                else if (hasMilk && !hasSugar && hasChocolate)
                    return fullDrink = new MilkDecorator(new ChocolateDecorator(drinkOrder));
                if (hasMilk && hasSugar && !hasChocolate)
                    return fullDrink = new MilkDecorator(new SugarDecorator(drinkOrder));
                else if (!hasMilk && !hasSugar && hasChocolate)
                    return fullDrink = new ChocolateDecorator(drinkOrder);
                else if (hasMilk && !hasSugar && !hasChocolate)
                    return fullDrink = new MilkDecorator(drinkOrder);
                else if (!hasMilk && hasSugar && !hasChocolate)
                    return fullDrink = new SugarDecorator(drinkOrder);
                else
                    //drink without addIns
                    return drinkOrder;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Manage the Tea addIns follows some rules
        /// </summary>
        /// <param name="drinkOrder"></param>
        /// <param name="hasMilk"></param>
        /// <param name="hasSugar"></param>
        /// <returns></returns>
        public static IDrink ProcessTeaAddIns(IDrink drinkOrder, bool hasMilk, bool hasSugar)
        {
            IDrink fullDrink;

            try
            {
                //IceTea allows just sugar
                if (drinkOrder.GetType() == typeof(IceTea))
                {
                    if (hasSugar)
                        return fullDrink = new SugarDecorator(drinkOrder);
                    else
                        return drinkOrder;
                }
                else
                {
                    //Tea does not allow Chocolate
                    if (hasMilk && hasSugar)
                        return fullDrink = new MilkDecorator(new SugarDecorator(drinkOrder));
                    else if (!hasMilk && hasSugar)
                        return fullDrink = new SugarDecorator(drinkOrder);
                    else if (hasMilk && !hasSugar)
                        return fullDrink = new MilkDecorator(drinkOrder);
                    else
                        return drinkOrder;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

    }
}
