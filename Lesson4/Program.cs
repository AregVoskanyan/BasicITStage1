//----------\Loops/----------\\

//for (int i = 17; i > 4; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 23; i < 30; i++) Console.WriteLine(i);
//var i = 1;
//for (Console.WriteLine("cycle work start"); i < 4; Console.WriteLine($"i = {i}"))
//{
//    i++;
//}

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.WriteLine(i + "*" + j + "=" + i * j);
//    }
//    Console.WriteLine();
//}
using System;
namespace Loops
{
    class Prgram
    {
        static void Main()
        {
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"BLOCK: counter = {counter}");
                counter++;
            }

            Console.WriteLine($"MAIN: counter = {counter}");
        }
    }
}