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


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            AddConstructor Car1 = new AddConstructor("Ferrari",100,2000);
            Console.WriteLine(Car1.brand + ", " + Car1.speed + ", " + Car1.year );
        }
    }
}
