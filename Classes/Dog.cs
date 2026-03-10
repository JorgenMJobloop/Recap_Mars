public class Dog : Animal
{
    public override string Subspecies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Breed { get; set; }

    public Dog(string species, string habitat) : base(species, habitat)
    {
        Breed = null!;
    }
}