public class Product : IEntity
{
    /// <summary>
    /// Unique identifier (Primary key in a database)
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// A globally unique identitifer (UUID) using Microsoft naming convention (Guid)
    /// </summary>
    public Guid GUID { get; set; }
    /// <summary>
    /// Name of the product
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Product manifacturer
    /// </summary>
    public string Manifacturer { get; set; } = string.Empty;
    /// <summary>
    /// A price property (price of each individual product)
    /// </summary>
    public double Price { get; set; }

    public int UnitsAvailable { get; set; }

    public override string ToString()
    {
        return $"Manifacturer: {Manifacturer}\nProduct: {Name}, Price: {Price:C}, GUID: {GUID} In stock: {UnitsAvailable}";
    }
}