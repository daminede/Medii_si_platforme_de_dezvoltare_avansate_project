// Dog.cs
public class Dog : IAnimal
{
    public string Type => "Dog";
    public string Sound => "Bark";
    public Dog()
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
