public class Dog : Animal
{
    public override string Subspecies => "Terrier";
    public string Breed { get; set; }

    public Dog(string species, string habitat) : base(species, habitat)
    {
        Breed = null!;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bark bark!");
    }
}