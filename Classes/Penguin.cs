public class Penguin : Animal
{
    public override string Subspecies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Penguin(string species, string habitat) : base(species, habitat)
    {

    }

}