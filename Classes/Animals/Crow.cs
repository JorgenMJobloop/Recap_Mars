public class Crow : Animal, IFlight
{
    public override string Subspecies { get; }
    public Crow(string species, string habitat, string subspecies) : base(species, habitat)
    {
        Subspecies = subspecies;
    }

    public virtual void CanFly()
    {
        Console.WriteLine($"{Species} can fly!");
    }

    public override void MakeSound()
    {

    }
}