using System.Collections.Generic;

public static class AnimalValidator
{
    private static readonly Dictionary<string, string> ValidAnimals = new()
    {
        { "Dog", "Bark" },
        { "Cat", "Meow" },
        { "Cow", "Moo" },
        { "Sheep", "Baa" },
        { "Duck", "Quack" }
    };

    public static bool IsValidAnimal(string type, string sound)
    {
        return ValidAnimals.TryGetValue(type, out var validSound) && validSound == sound;
    }
}
