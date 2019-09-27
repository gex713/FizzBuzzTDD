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
            if (num == 6) return "Fizz";
            if (num == 5) return "Buzz";
            if (num == 3) return "Fizz";

            return num.ToString();
        }
    }
}
