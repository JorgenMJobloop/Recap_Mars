using System.Text.Json;

public class JsonRepository<Item> : IRepository<Item> where Item : IEntity
{
    /// <summary>
    /// A read-only collection that is encapsulated within the JsonRepository class
    /// </summary>
    private readonly List<Item> _items = new List<Item>();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public IEnumerable<Item> GetAllItems()
    {
        return _items;
    }

    public Item? GetItemUsingId(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }

    public void TryLoadFromFile(string filePath)
    {
        // Check if the file we want to read from exists in the current working directory.
        if (!File.Exists(filePath))
        {
            return;
        }

        // try to read the contents of the file we have opened.
        try
        {
            string jsonContent = File.ReadAllText(filePath);
            // we then try to "deserialize" this means "reading 
            // a text and translating it to something our compiler understands (a C# Class/object)
            List<Item>? contents = JsonSerializer.Deserialize<List<Item>>(jsonContent);

            // if the load operation was successful, we clear the items list and "overwrite" the content with the loaded content.
            _items.Clear();

            if (contents is not null)
            {
                _items.AddRange(contents);
            }
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine($"An error occured when trying to open the file for reading: {ex.Message}");
        }
    }

    public void TrySaveToFile(string filePath)
    {
        // JSON serializer options for text-formatting that matches the JSON standard format
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonData = JsonSerializer.Serialize(_items, options);

        try
        {
            // Write the content of the repository, to a file specified by the filePath we choose.
            File.WriteAllText(filePath, jsonData);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine($"An error occured when trying to write to the file: {ex.Message}");
        }
    }
}