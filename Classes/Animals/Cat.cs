public class Cat : Animal
{
    public override string Subspecies => "Housecat";
    public Cat(string species, string habitat) : base(species, habitat)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}