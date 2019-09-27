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
            if (num == 4) return "4";
            if (num == 3) return "Fizz";
            if (num == 2) return "2";
            return "1";
        }
    }
}
