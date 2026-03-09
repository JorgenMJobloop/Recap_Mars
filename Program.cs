namespace Recap_Mars;

class Program
{
    static void Main(string[] args)
    {
        // create a new object instance of a class
        var dog = new Animal(new Dog(), "");
        Console.WriteLine(dog.Species);
    }
}