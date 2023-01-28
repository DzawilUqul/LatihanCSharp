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

    class AddProperty
    {
        private int speed = 500;
        public int Speed
        {
            get{return speed;}
            set
            {
                if(value > 500)
                {
                    value = speed;
                }else
                {
                    speed = value;
                }
            }
        }
    }

    class SimpleProperty
    {
        public int Price
        {get; set;}
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

    interface AddInterface1
    {
        void myMethod1();
    }

    interface AddInterface2
    {
        void myMethod2();
    }

    class ChildInterface : AddInterface1,AddInterface2
    {
        public void myMethod1()
        {
            Console.WriteLine("Interface Method 1");
        }

        public void myMethod2()
        {
            Console.WriteLine("Interface Method 2");
        }
    }

    class myEnum
    {
        public enum Level
            {
                Easy,
                Medium,
                Hard
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

            // Property
            AddProperty Car2 = new AddProperty();
            Car2.Speed = 600;
            Console.WriteLine("Max Speed : " + Car2.Speed);

            SimpleProperty Car3 = new SimpleProperty();
            Car3.Price = 700;
            Console.WriteLine("Price : " + Car3.Price);

            // Inheritance
            Cat cat1 = new Cat();
            AddInheritance animal1 = new AddInheritance();
            Console.WriteLine(cat1.animal + cat1.type);
            animal1.animalSound();
            cat1.animalSound();

            // Interface
            ChildInterface myInterface1 = new ChildInterface();
            myInterface1.myMethod1();
            myInterface1.myMethod2();

            myEnum.Level myLevel = myEnum.Level.Medium;
            switch (myLevel)
            {
                case myEnum.Level.Easy:
                    Console.WriteLine("Easy");
                    break;

                case myEnum.Level.Medium:
                    Console.WriteLine("Medium");
                    break;
                    
                case myEnum.Level.Hard:
                    Console.WriteLine("Hard");
                    break;
                default:
                    Console.WriteLine("Undefined");
                    break;
            }

            int s = 0;
            
        }
    }
}
