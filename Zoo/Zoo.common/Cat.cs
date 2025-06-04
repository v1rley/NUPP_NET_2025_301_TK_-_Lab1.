using System;

namespace Zoo.Common
{
    public class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
            TotalAnimals++;
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " каже: Мяу!");
        }
    }
}
