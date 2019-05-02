

namespace AcuCafeCore.Factories
{
    /// <summary>
    /// Factory of Coffe Factory or a Tea Factory
    /// </summary>
    public class AcuCafeFactoryProducer
    {
        /// <summary>
        /// Generate a Coffe Factory or a Tea Factory
        /// </summary>
        /// <param name="isCoffee"></param>
        /// <returns></returns>
        public static AbstractAcuCafeFactory GetAcuCafeFactory(bool isCoffee)
        {
            if (isCoffee)
            {
                return new CoffeeFactory();
            }
            else
            {
                return new TeaFactory();
            }
        }
    }
}
