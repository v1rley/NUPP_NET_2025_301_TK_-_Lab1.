using System;
using Zoo.Common;
using Zoo.Common;
using Zoo.Common;

namespace Zoo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrudService<Cat> catService = new CrudService<Cat>();
            ICrudService<Dog> dogService = new CrudService<Dog>();

            Cat cat = new Cat("Мурка", 3, "Сіра");
            Dog dog = new Dog("Рекс", 5, "Лабрадор");

            catService.Create(cat);
            dogService.Create(dog);

            System.Console.WriteLine("=== Коти ===");
            foreach (Cat c in catService.ReadAll())
            {
                System.Console.WriteLine("Ім'я: " + c.Name + ", Вік: " + c.Age + ", Колір: " + c.Color);
                c.Speak();
            }

            System.Console.WriteLine("=== Собаки ===");
            foreach (Dog d in dogService.ReadAll())
            {
                System.Console.WriteLine("Ім'я: " + d.Name + ", Вік: " + d.Age + ", Порода: " + d.Breed);
                d.Speak();
            }

            System.Console.ReadLine();
        }
    }
}
