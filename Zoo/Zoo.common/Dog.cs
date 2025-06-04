using System;

namespace Zoo.Common
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
            TotalAnimals++;
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " каже: Гав!");
        }
    }
}
