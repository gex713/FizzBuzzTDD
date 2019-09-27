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
            string result = string.Empty;
            
            if (num % 3 == 0) result += "Fizz";
            if (num % 5 == 0) result += "Buzz";

            if (num % 3 != 0 && num % 5 != 0) result = num.ToString();

            return result;
        }
    }
}
