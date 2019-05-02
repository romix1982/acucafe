

namespace AcuCafeCore.Factories
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class AbstractAcuCafeFactory
    {
        /// <summary>
        /// Generates a base drink
        /// </summary>
        /// <param name="drinkDescription"></param>
        /// <returns></returns>
        public abstract IDrink GetDrink(AcuCafeEnum.EnumDrinks drinkDescription);
    }
}
