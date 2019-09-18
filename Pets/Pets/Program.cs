using System;
using System.Collections.Generic;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dog1 = new Pet();
            dog1.Age = 3;
            dog1.Name = "Ralph"; 
            dog1.Legs = 3;
            dog1.Breed = "Husky";
            dog1.Sound = "Woof!";

            var cat = new Pet(6, "whiskers", 4, "Short-Hair", "Meow");
            var snake = new Pet(7, "buford", 0, "Mambo", "hisss");
            var fish = new Pet(2, "bubbles", 0, "Goldfish", "bouble bouble");
            List<Pet> myPets = new List<Pet>();
            myPets.Add(dog1);
            myPets.Add(cat);
            myPets.Add(snake);
            myPets.Add(fish);
            foreach(var animal in myPets)
            {
                Console.WriteLine($"Pet Name;{animal.Name}, Age of pet: {animal.Age}");
            }

        }
    }
}
