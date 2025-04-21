// Cow.cs
public class Cow : IAnimal
{
    public string Type => "Cow";
    public string Sound => "Moo";
    public Cow()
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
