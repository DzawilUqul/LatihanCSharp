using System;

namespace OOP2
{
    class AddConstructor
    {
        public string brand;
        public int speed;
        public int year;

        public AddConstructor(string cBrand, int cSpeed, int cYear)
        {
            brand = cBrand;
            speed = cSpeed;
            year = cYear;
        }
    }

    class AddInheritance
    {
        public string animal = "Animal : ";
        public virtual void animalSound()
        {
            Console.Write("Animal Sound : ");
        }
    }

    class Cat : AddInheritance
    {
        public string type = "cat";
        public int age = 8;
        public override void animalSound()
        {
            Console.WriteLine("Meow");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            AddConstructor Car1 = new AddConstructor("Ferrari",100,2000);
            Console.WriteLine(Car1.brand + ", " + Car1.speed + ", " + Car1.year );

            // Inheritance
            Cat cat1 = new Cat();
            AddInheritance animal1 = new AddInheritance();
            Console.WriteLine(cat1.animal + cat1.type);
            animal1.animalSound();
            cat1.animalSound();
        }
    }
}
