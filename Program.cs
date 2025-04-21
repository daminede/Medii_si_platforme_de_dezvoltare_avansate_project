using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animal Sounds App!");
            Console.WriteLine("Enter the name of an animal (e.g., Dog, Cat, Cow, Sheep, Duck) to hear its sound:");
            Console.WriteLine("Type 'exit' to quit the application.");

            var animalTypes = new List<string> { "Dog", "Cat", "Cow", "Sheep", "Duck" };

            while (true)
            {
                Console.Write("\nEnter animal name: ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (animalTypes.Exists(a => string.Equals(a, input, StringComparison.OrdinalIgnoreCase)))
                {
                    var animal = CreateAnimal(input);
                    animal.MakeSound();
                }
                else
                {
                    Console.WriteLine($"Invalid animal type: {input}. Please try again.");
                }
            }
        }

        private static IAnimal CreateAnimal(string type)
        {
            return type.ToLower() switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
                "cow" => new Cow(),
                "sheep" => new Sheep(),
                "duck" => new Duck(),
                _ => throw new InvalidOperationException($"Invalid animal type: {type}.")
            };
        }
    }
}
