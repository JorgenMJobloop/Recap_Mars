/// <summary>
/// Animal superclass, contains various abstract information about a range of different animals
/// </summary>
public abstract class Animal
{
    public string Species { get; set; }
    public abstract string Subspecies { get; }
    public string Habitat { get; set; } = string.Empty;

    /// <summary>
    /// optional constructor, allows determining values in inherited members, or when directly assigned as a object. 
    /// </summary>
    /// <param name="species"></param>
    /// <param name="habitat"></param>
    public Animal(string species, string habitat)
    {
        Species = species ?? throw new ArgumentNullException(nameof(species));
        Habitat = habitat ?? throw new ArgumentNullException(nameof(habitat));
    }

    // methods

    /// <summary>
    /// The sound the animal makes
    /// </summary>
    public abstract void MakeSound();

    /// <summary>
    /// Get the specific species of an animal
    /// </summary>
    /// <returns>species</returns>
    public virtual string GetSpecies()
    {
        return Species;
    }

    public override string ToString()
    {
        return $"{Species} ({Subspecies}) - Habitat : {Habitat}.";
    }
}