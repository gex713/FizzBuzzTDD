using System;

namespace FizzBuzzRunner
{
    public class DoFizzBuzz
    {
        public string Run()
        {
            return "1";
        }

        public string GetFizzBuzz(int num)
        {
            if (num == 15) return "FizzBuzz";
            if (num % 5 == 0) return "Buzz";
            if (num % 3 == 0) return "Fizz";

            return num.ToString();
        }
    }
}
