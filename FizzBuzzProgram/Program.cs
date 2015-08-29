using System;


namespace FizzBuzzProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                FizzBuzz fb = new FizzBuzz();
                string result = fb.DetermineOutput(x);
                Console.Write(result);
                Console.WriteLine();
            }
        }
    }
}
