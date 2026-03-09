/// <summary>
/// Animal superclass, contains various abstract information about a range of different animals
/// </summary>
public class Animal
{
    /// <summary>
    /// Set this in the superclass, as a "registry"
    /// </summary>
    public List<Animal> AllSpecies = new List<Animal>();
    public Animal Species { get; set; }
    public string Habitat { get; set; } = string.Empty;
    public bool CanFly { get; private set; }


    /// <summary>
    /// Primary constructor, empty object assignments allowed
    /// </summary>
    public Animal()
    {
        Species = null!;
    }

    /// <summary>
    /// optional constructor, allows determining values in inherited members, or when directly assigned as a object. 
    /// </summary>
    /// <param name="species"></param>
    /// <param name="habitat"></param>
    public Animal(Animal species, string habitat)
    {
        Species = species;
        Habitat = habitat;
    }

    /// <summary>
    /// Checks whether or not a specific animal, has the ability to fly.
    /// </summary>
    /// <returns>bool</returns>
    public virtual bool CanFlyIfCorrectSpecies()
    {
        if (AllSpecies.Contains(Species))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Add a new species to the registry, when this superclass is instanciated.
    /// </summary>
    public void AddNewSpecies()
    {
        AllSpecies.Add(Species);
    }

    /// <summary>
    /// Remove a single species from the species registry list.
    /// </summary>
    /// <param name="species">a specific animal species</param>
    public virtual void RemoveFromSpeciesList(Animal species)
    {
        AllSpecies.Remove(species);
    }
}