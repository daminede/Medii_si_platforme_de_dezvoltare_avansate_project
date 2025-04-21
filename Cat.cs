// Cat.cs
public class Cat : IAnimal
{
    public string Type => "Cat";
    public string Sound => "Meow";
    public Cat()
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
