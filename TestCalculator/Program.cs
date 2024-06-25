using System;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("A = ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("B = ");
                int b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please, select operation 1:+ 2:- 3:* 4:/ 5:exit (enter only numbers) : ");
                int operation = Int32.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("{0} + {1} = {2}",a,b, a + b);
                }
                if (operation == 2)
                { 
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                }
                if(operation == 3)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                }
                if (operation == 4)
                {
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                }
                if (operation == 5)
                {
                    break;
                }

            }
          Console.ReadLine();

        }
    }
}