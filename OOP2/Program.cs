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
        }
    }
}
