namespace Recap_Mars;

class Program
{
    static void Main(string[] args)
    {
        // // create a new object instance of a class
        // var dog = new Dog("Canine", "Human-companions/Urban/Woodland/Coastal");

        // var animals = new List<Animal>()
        // {
        //     dog,
        //     new Cat("Feline", "Human-companions/Urban/Woodland/Desert/Coastal"),
        //     new Crow("Bird", "Urban/Woodland/Coastal/Rural", "Crow"),
        //     new Penguin("Bird", "Arctic/Coastal")
        // };

        // foreach (var animal in animals)
        // {
        //     //Console.WriteLine($"Animal species in the list: {animal.Species}. Animal habitats in list: {animal.Habitat}. {animal.Species}");
        //     Console.WriteLine(animal.ToString());
        //     animal.MakeSound();
        // }

        var repository = new JsonRepository<Product>();

        var products = new List<Product>()
        {
            new Product {Id = 1, GUID = Guid.NewGuid(), Manifacturer = "Razor",Name = "Mouse", Price = 850, UnitsAvailable = 10},
            new Product {Id = 2, GUID = Guid.NewGuid(), Manifacturer = "Steelseries",Name = "Headset", Price = 500, UnitsAvailable = 8},
            new Product {Id = 3, GUID = Guid.NewGuid(), Manifacturer = "HyperX",Name = "Keyboard", Price = 450, UnitsAvailable = 20},
            new Product {Id = 4, GUID = Guid.NewGuid(), Manifacturer = "Apple", Name = "IPhone", Price = 10000, UnitsAvailable = 15},
            new Product {Id = 5, GUID = Guid.NewGuid(), Manifacturer = "Razor", Name = "Headset", Price = 1200, UnitsAvailable = 5}
        };

        var customers = new List<Customer>
        {
            new Customer {Id = 1, FullName = "John Doe", Email = "Johndoe@example.com"},
            new Customer {Id = 2}
        };

        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
            repository.AddItem(product);
        }

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.ToString());
        }

        //repository.TrySaveToFile("data.json");

        var item = repository.GetItemUsingId(1);
        Console.WriteLine(item!.Manifacturer);
    }
}