using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal { Type = "Dog", Sound = "Bark" },
                new Animal { Type = "Cat", Sound = "Meow" },
                new Animal { Type = "Cow", Sound = "Moo" },
                new Animal { Type = "Sheep", Sound = "Baa" },
                new Animal { Type = "Duck", Sound = "Quack" }
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Type} makes sound: {animal.Sound}");
            }
        }
    }

    class Animal
    {
        public string Type { get; set; }
        public string Sound { get; set; }
    }
}
