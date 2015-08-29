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

            if (num % 15 == 0)
            {
                output = "FizzBuzz";
            }
            else if(num % 3 == 0)
            {
                output += "Fizz";
            }

            else if(num % 5 == 0)
            {
                output += "Buzz";
            }

           else 
            {
                output = num.ToString();
            }

            return output;

        }

       
    }
}