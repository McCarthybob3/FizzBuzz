using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }

        static void Execute()
        {
            //TODO:  Implement FizzBuzz
            int i;
            string fizz;
            string buzz;

            for (i = 0; i <= 100; i++) 
            {
             

                if (i % 3 == 0)
                {
                    fizz = "fizz";
                }
                else {
                    fizz = null;
                }

                if(i%5 == 0)
                {
                    buzz = "buzz";
                }
                else
                {
                    buzz = null;
                }
                Console.WriteLine($"{i} " + fizz + buzz);
            }
            Console.ReadLine();
        }
    }
}
