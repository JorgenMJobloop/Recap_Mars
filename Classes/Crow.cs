public class Crow : Animal
{
    public override string Subspecies { get; set; }
    public Crow(string species, string habitat, string subspecies) : base(species, habitat)
    {
        Subspecies = subspecies;
    }

    public override bool Fly()
    {
        return true;
    }
}