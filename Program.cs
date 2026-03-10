namespace Recap_Mars;

class Program
{
    static void Main(string[] args)
    {
        // create a new object instance of a class
        var dog = new Dog("Canine", "Human-companions/Urban/Woodland/Coastal");
        Console.WriteLine(dog.Species);
        dog.Breed = "Terrier";
        Console.WriteLine(dog.Breed);
        Console.WriteLine($"Can a dog fly? True or false -> {dog.CanFly}");

        var animals = new List<Animal>()
        {
            dog,
            new Cat("Feline", "Human-companions/Urban/Woodland/Desert/Coastal"),
            new Crow("Bird", "Urban/Woodland/Coastal/Rural", "Crow"),
            new Penguin("Bird", "Arctic/Coastal")
        };


        foreach (var animal in animals)
        {
            Console.WriteLine($"Animal species in the list: {animal.Species}. Animal habitats in list: {animal.Habitat}. {animal.Species} can fly: {animal.CanFly}");
        }

    }
}