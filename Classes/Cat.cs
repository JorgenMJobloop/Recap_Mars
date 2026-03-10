public class Cat : Animal
{
    public override string Subspecies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Cat(string species, string habitat) : base(species, habitat)
    {

    }
}