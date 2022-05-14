using System;

namespace Methods
{
    class Program
    {
        //--- 1 Simple Void Method ---\\
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        //--- 2 Method With Parametrs ---\\\
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        //--- 3 Method With Return Values ---\\\
        public static string GetMessage()
        {
            return "Hello World!";
        }

        //--- 4 Recursive Functions ---\\
        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //--- 1 Simple Void Method ---\\
            SayHello();

            //--- 2 Method With Parametrs ---\\\
            PrintMessage("Hello World!");
            Sum(7, 9);

            //--- 3 Method With Return Values ---\\\
            string message = GetMessage();
            Console.WriteLine(message);

            //--- 4 Recursive Functions ---\\
            int factorial5 = Factorial(5);
            Console.WriteLine(factorial5);
        }
    }
}