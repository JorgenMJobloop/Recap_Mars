public class Customer : IEntity
{
    /// <summary>
    /// Unique ID (Primary key in DB)
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Optional customer data, if the customer does not wish to share their full name, we can default to "Guest"
    /// </summary>
    public string FullName { get; set; } = "Guest";
    /// <summary>
    /// Customer email, optional, can be empty if customer does not want to share their email.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Customer information. Name: {FullName}, Email address: {Email}";
    }
}