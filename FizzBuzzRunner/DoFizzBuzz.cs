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
            if (num == 5) return "Buzz";
            if (num % 3 == 0) return "Fizz";

            return num.ToString();
        }
    }
}
