/// <summary>
/// The generic data type "Items" can be any datatype we specify when this interface is implemented in any class that implements it.
/// </summary>
/// <typeparam name="Item">Any incoming datatype</typeparam>
public interface IRepository<Item> where Item : IEntity
{
    /// <summary>
    /// Add a new item to the repository.
    /// </summary>
    /// <param name="item">Any item we choose (string, double, Customer, Product)</param>
    void AddItem(Item item);
    /// <summary>
    /// Get all the items in the repository as a enumerable from collection
    /// </summary>
    /// <returns>IEnumerable</returns>
    IEnumerable<Item> GetAllItems();
    /// <summary>
    /// Get a specific item using the item's Id (unique)
    /// </summary>
    /// <param name="id">the Id the item has</param>
    /// <returns>Item</returns>
    Item? GetItemUsingId(int id);
    /// <summary>
    /// Try to save the content currently in the item repository to a file
    /// </summary>
    /// <param name="filePath">the file to save the data to</param>
    /// <exception cref="FileLoadException"/>
    void TrySaveToFile(string filePath);
    /// <summary>
    /// Try to load existing data from a file that corresponds to the data in the repository
    /// </summary>
    /// <param name="filePath"><the file to load data from/param>
    /// <exception cref="FileLoadException"/>
    void TryLoadFromFile(string filePath);
}