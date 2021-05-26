using System;

namespace MyFirstCsharp
{
    class Omkar
    {

        public static void m1()
        {
            Console.WriteLine("I am in m1");
            m2();
            
            
        }

        public static void m2()
        {
            Console.WriteLine("I am in m2");

        }


        public static void Main(string[] args)
        {
            Console.WriteLine("This Is My First C# Programme.....!!!!");
           Omkar obj = new Omkar();
            m1();
           


        }
    }
}



