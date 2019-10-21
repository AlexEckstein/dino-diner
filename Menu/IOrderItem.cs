/*  IOrderItem.cs
*   Author: Alex Eckstein
*/

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}
