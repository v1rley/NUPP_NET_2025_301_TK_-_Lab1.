using System;

namespace Zoo.Common
{
    public abstract class Animal
    {
        public static int TotalAnimals;

        static Animal()
        {
            TotalAnimals = 0;
        }

        protected Animal()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Speak();
    }
}
