namespace DataStructuresFinal
{
    /// <summary>
    /// Creates a Cart class that contains a name and a price.
    /// </summary>
    public class CartClass
    {
        /// <summary>
        /// Holds the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Holds the price of an Item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// CartClass default constructor
        /// </summary>
        /// <param name="conName">The name of the items.</param>
        /// <param name="conPrice">The items price.</param>
        public CartClass(string conName, decimal conPrice)
        {
            Name = conName;
            Price = conPrice;
        }
    }
}