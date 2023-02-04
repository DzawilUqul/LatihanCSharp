// See https://aka.ms/new-console-template for more information
using System;

namespace BasicCSharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void method1()
        {
            Console.WriteLine("\nIni Method 1");
        }

        static void method2(string fname)
        {
            Console.WriteLine(fname + " 4104");
        }

        static void method3(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void method4(string country = "norway")
        {
            Console.WriteLine(country);
        }

        static int method5(int a)
        {
            return 5 + a;
        }

        static int method6(int a,int b)
        {
            return a - b;
        }

        static void method7(string name1, string name2, string name3)
        {
            Console.WriteLine("My Youngest Child Is " + name3);
        }

        static int method8(int a, int b)
        {
            return a + b;
        }

        static double method8(double a, double b)
        {
            return a + b;
        }
            
            

        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WindowHeight = 40;

            Console.WriteLine("Heladwdwalo, World!");
            // Console.ReadLine();
            Console.WriteLine("waddwwd");

            double a = 5.4;
            int b = (int) a;

            Console.WriteLine(Convert.ToInt32(a));

            // Math Syntax
            int mathA = 44;
            int mathB = 55;
            int mathSqrt = 144;
            int mathAbs = -577;
            double mathRound = 3.89;

            Console.WriteLine("Nilai Max : " + Math.Max(mathA,mathB));
            Console.WriteLine("Nilai Min : " + Math.Min(mathA,mathB));

            Console.WriteLine("Akar dari : " + Math.Sqrt(mathSqrt));

            Console.WriteLine("Nilai absolute : " + Math.Abs(mathAbs));

            Console.WriteLine("Nilai Pembulatan : " + Math.Round(mathRound));

            // String

            string myString = "oawdjoiadjoiawdjioa";
            string myString2 = "ADKJDJAWK";
            Console.WriteLine("Panjang String : " + myString.Length);
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString2.ToLower());

            // Array

            int[] arr = {1,2,3};

            for(int i=0; i<3; i++){
                Console.Write(arr[i] + " ");
            }

            // Method

            method1();

            method2("\nadi");
            method2("ali");
            method2("abi");

                // Multiple parameters

            method3("\nadi", 15);
            method3("ali", 16);
            method3("abi", 17);

                // Default Parameter

            method4("\nIndo");
            method4("Malay");
            method4();

                // Return value 
            
            Console.WriteLine("\n" + method5(5));
            Console.WriteLine("\n" + method6(6,1));
            int z = method6(7,3);
            Console.WriteLine("\n" + z);

                // Named Arguments

            method7(name1:"Jhon", name3:"Ed", name2:"Bob");

                // Method Overloading

            int overloadInt = method8(3,5);
            double overloadDouble = method8(3.5 , 5.6);
            
            Console.WriteLine("\n" + overloadInt);
            Console.WriteLine("\n" + overloadDouble);

            double nilai = 84.9;
            Console.WriteLine(Math.Round(nilai));

            Console.WriteLine("cek");

        }
    }
}

