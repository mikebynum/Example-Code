using System;


namespace FizzBuzzKata
{
    public class FizzBuzz
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

            Console.Read();
        }

        public string DetermineOutput(int num)
        {
            string output = "";

            if(num % 3 == 0)
            {
                output += "Fizz";
            }

            if(num % 5 == 0)
            {
                output += "Buzz";
            }

            if (output == "")
            {
                output = num.ToString();
            }

            return output;

        }

       
    }
}