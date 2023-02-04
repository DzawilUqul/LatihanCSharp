using System;

namespace OOP
{

    class Car
    {
        public string color = "red";
    }

    class Monitor
    {
        int hz = 60;
        public void speedMonitor()
        {
            Console.WriteLine("This Monitor is : " + hz + "hz");
        }
    }

    class Keyboard
    {
        public static void keyboardKeys(int keys)
        {
            Console.WriteLine("This Keyboard is : " + keys + " keys");
        }
    }

    // Constructors
    class Mouse
    {
        public string brand;   // Field

        public Mouse()  // Class Constructor
        {
            brand = "Razer";
        }
    }

    // Access Modifier (Private)
        // class Store
        // {
        //     private string brand = "HnM";
        //     string size = "XL";
        //     static void Main(string[] args)
        //     {
        //         Store store1 = new Store();
        //         Console.WriteLine(store1.brand);
        //     }
        // }

    // Constructor With Parameters
    class MouseParameter
    {
        public string brand;
        public int dpi;
        public int price;

        public MouseParameter(string cModel, int cDpi, int cPrice)
        {
            brand = cModel;
            dpi = cDpi;
            price = cPrice;
        }
    }

    // Properties
    class NameProperty
    {
        private string name;  // Field
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
    }

        // Using Automatic Properties
        class NameProperty2
        {
            public int Age
            {get; set;}
        }

    // Example Property 
    class Bio
    {
        public string nameBio;
        private string gender;

        public Bio(string cName, string cGender)
        {
            nameBio = cName;
            Gender = cGender;
        }

        public string Gender
        {
            get {return gender;}
            set 
            {
                if(value == "Male" || value == "Female")
                {
                    gender = value;
                }else
                {
                    throw new ArgumentException("Invalid value supplied");
                }
            }
        }
    }

    // Inheritance
    class Marvel        // You can use "sealed" if you don't want other class to inherit from class
    {
        public string mcu;
        public void assemble()
        {
            Console.WriteLine("Avengers....!!!! Assemble...");
        }
    }

    class Avengers : Marvel
    {
        public string member;
        public string weapon;

        public Avengers(string cMember,string cWeapon)
        {
            member = cMember;
            weapon = cWeapon;
        }
    }

    // Polymorphism
    
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound : ");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Oink Oink");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Woof Woof");
        }
    }

    // Abstraction

    abstract class Password
    {
        public abstract void pass();
        public void passDefault()
        {
            Console.WriteLine("Facebook default password : 12345678");
        }
    }

    class Facebook : Password
    {
        public override void pass()
        {
            Console.WriteLine("Default password changed to : qwerty");
        }
    }

    // Interface

    interface IPassword
    {
        void passDefault();     // Interface members are by default abstract and public
    }

    class Instagram : IPassword
    {
        public void passDefault()       // Don't have to use "override"
        {
            Console.WriteLine("Insta Default Pass : 12345678");
        }
    }

    // Multiple Interface

    interface IMyInterface1
    {
        void myMethod1();
    }

    interface IMyInterface2
    {
        void myMethod2();
    }

    class DemoClass : IMyInterface1, IMyInterface2
    {
        public void myMethod1()
        {
            Console.WriteLine("This is myInterface1");
        }

        public void myMethod2()
        {
            Console.WriteLine("This is myInterface2");
        }
    }

    // Enums
    enum Level
    {
        Low,
        Medium,
        High
    }

        // Enum Inside Class
        class EnumClass
        {
            public enum Difficulty
            {
                Easy,
                Medium,
                Hard
            }
        }

        // Enum Value
        enum Months
        {
            January,
            February = 2,
            March,
            April
        }

        // Enum In Switch Case Statement
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday
        }







     internal class LatihanOOP
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Car myObj = new Car();

            Console.WriteLine(myObj.color);
            

            // multiple object

            Car myObj2 = new Car();
            Car myObj3 = new Car();

            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj3.color);

            // Multiple Classes (newClass.cs)

            Book book1 = new Book();
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            // Class with blank fields

            Laptop asus = new Laptop();
            asus.cpu = "Intel";
            asus.vga = "mx250";
            asus.price = 10;

            Laptop acer = new Laptop();
            acer.cpu = "Amd";
            acer.vga = "GTX 1650";
            acer.price = 15;

            Console.WriteLine(asus.cpu);
            Console.WriteLine(acer.cpu);
            Console.WriteLine(asus.vga);
            Console.WriteLine(acer.vga);

            // Object Method (Public)
            Monitor samsung = new Monitor();
            samsung.speedMonitor();

            // Object Method (Static)
            Keyboard.keyboardKeys(69);

            // Constructors

            Mouse mouse1 = new Mouse();
            Console.WriteLine("This mouse is : " + mouse1.brand);

                // Constructor with parameters

                MouseParameter mouse2 = new MouseParameter("Razer",1600,250);
                Console.WriteLine(mouse2.brand +", " + mouse2.dpi +", " + mouse2.price);
            
            // Properties
            NameProperty nameProp = new NameProperty();
            nameProp.Name = "Liam";
            Console.WriteLine(nameProp.Name);

                // Automatic Properties (Short Hand)
                NameProperty2 person1 = new NameProperty2();
                person1.Age = 20;
                Console.WriteLine(person1.Age);

                // Properties Example
                Bio student1 = new Bio("adi ","Male");
                Console.WriteLine(student1.nameBio + student1.Gender);

            // Inheritance
            Avengers capt = new Avengers("Captain America","Vibranium Shield");
            Console.WriteLine(capt.member + " with his " + capt.weapon + " said : ");
            capt.assemble();

            // Polymorphism
            Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Dog myDog = new Dog();
            
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            // Abstraction
            Facebook myFacebook = new Facebook();
            myFacebook.passDefault();
            myFacebook.pass();

            // Interface
            Instagram myInsta = new Instagram();
            myInsta.passDefault();

                // Multiple Interface
                DemoClass myObjectInterface = new DemoClass();
                myObjectInterface.myMethod1();
                myObjectInterface.myMethod2();

            // Enums
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

                // Enum Inside Class
                EnumClass.Difficulty myDiff = EnumClass.Difficulty.Easy;
                Console.WriteLine(myDiff);

                // Enum Value 
                Months firstMonth = Months.January;
                int intFirstMonth = (int) firstMonth;
                Console.WriteLine(intFirstMonth);

                int secondMonth = (int) Months.February;
                Console.WriteLine(secondMonth);

                // Enum In a Switch Case Statement
                Days myDays = Days.Tuesday;
                switch (myDays)
                {
                    case Days.Tuesday:
                        Console.WriteLine("Today is Tuesday");
                        break;
                    default:
                        Console.WriteLine("--");
                        break;
                }
                
                int b = 0;
            

        }
    }
}