/// <summary>
/// Animal superclass, contains various abstract information about a range of different animals
/// </summary>
public abstract class Animal
{
    public string Species { get; set; }
    public abstract string Subspecies { get; set; }
    public string Habitat { get; set; } = string.Empty;
    public bool CanFly { get; private set; }

    /// <summary>
    /// optional constructor, allows determining values in inherited members, or when directly assigned as a object. 
    /// </summary>
    /// <param name="species"></param>
    /// <param name="habitat"></param>
    public Animal(string species, string habitat)
    {
        Species = species;
        Habitat = habitat;
        CanFly = Fly();
    }

    public virtual bool Fly()
    {
        return false;
    }
}