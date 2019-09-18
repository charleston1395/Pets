using System;
using System.Collections.Generic;
using System.Text;

namespace Pets
{
    public class Pet
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Legs { get; set; }
        public string Breed { get; set; }
        public Pet(int age, string name, int legs, string breed )
        {
            Age = age;
            Name = name;
            Legs = legs;
            Breed = breed;

        }

        public Pet()
        {

        }
        
        
        }
    }

