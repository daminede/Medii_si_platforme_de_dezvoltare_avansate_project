using System;

public class Sheep : IAnimal
{
    public string Type => "Sheep";
    public string Sound => "Baa";

    public Sheep()
    {
        if (!AnimalValidator.IsValidAnimal(Type, Sound))
        {
            throw new InvalidOperationException($"Invalid animal type or sound: {Type} - {Sound}");
        }
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Type} makes sound: {Sound}");
    }
}
