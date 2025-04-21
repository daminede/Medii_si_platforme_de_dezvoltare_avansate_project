// Duck.cs
public class Duck : IAnimal
{
    public string Type => "Duck";
    public string Sound => "Quack";
    public Duck()
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
