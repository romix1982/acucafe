

namespace AcuCafeCore
{
    /// <summary>
    /// Drink Template
    /// </summary>
    public interface IDrink
    {
        string Prepare();
        double Cost();
    }
}
