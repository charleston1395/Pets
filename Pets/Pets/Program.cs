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

            var cat = new Pet(6, "whiskers", 4, "Short-Hair");

            List<Pet> myPets = new List<Pet>();
            myPets.Add(dog1);
            myPets.Add(cat);

            foreach(var animal in myPets)
            {
                Console.WriteLine($"Pet Name;{animal.Name}, Age of pet: {animal.Age}");
            }

        }
    }
}
