using FizzBuzzRunner;
using FluentAssertions;
using System;
using Xunit;

namespace FizzBuzzTests
{
    public class Tests
    {
        [Fact]
        public void OneShouldBeReturned()
        {
            var runner = new DoFizzBuzz();

            var answer = runner.GetFizzBuzz(1);

            answer.Should().Be("1");
        }

        [Fact]
        public void TwoShouldBeReturned()
        {
            var runner = new DoFizzBuzz();

            var answer = runner.GetFizzBuzz(2);

            answer.Should().Be("2");
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "17")]
        [InlineData(18, "Fizz")]
        [InlineData(19, "19")]
        [InlineData(20, "Buzz")]
        [InlineData(21, "Fizz")]
        [InlineData(22, "22")]
        [InlineData(23, "23")]
        [InlineData(24, "Fizz")]
        [InlineData(25, "Buzz")]
        [InlineData(26, "26")]
        [InlineData(27, "Fizz")]
        [InlineData(28, "28")]
        [InlineData(29, "29")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(31, "31")]
        [InlineData(32, "32")]
        [InlineData(33, "Fizz")]
        [InlineData(34, "34")]
        [InlineData(35, "Buzz")]
        [InlineData(36, "Fizz")]
        [InlineData(37, "37")]
        [InlineData(38, "38")]
        [InlineData(39, "Fizz")]
        [InlineData(40, "Buzz")]
        [InlineData(41, "41")]
        [InlineData(42, "Fizz")]
        [InlineData(43, "43")]
        [InlineData(44, "44")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(46, "46")]
        [InlineData(47, "47")]
        [InlineData(48, "Fizz")]
        [InlineData(49, "49")]
        [InlineData(50, "Buzz")]
        [InlineData(51, "Fizz")]
        [InlineData(52, "52")]
        [InlineData(53, "53")]
        [InlineData(54, "Fizz")]
        [InlineData(55, "Buzz")]
        [InlineData(56, "56")]
        [InlineData(57, "Fizz")]
        [InlineData(58, "58")]
        [InlineData(59, "59")]
        [InlineData(60, "FizzBuzz")]
        [InlineData(61, "61")]
        [InlineData(62, "62")]
        [InlineData(63, "Fizz")]
        [InlineData(64, "64")]
        [InlineData(65, "Buzz")]
        [InlineData(66, "Fizz")]
        [InlineData(67, "67")]
        [InlineData(68, "68")]
        [InlineData(69, "Fizz")]
        [InlineData(70, "Buzz")]
        [InlineData(71, "71")]
        [InlineData(72, "Fizz")]
        [InlineData(73, "73")]
        [InlineData(74, "74")]
        [InlineData(75, "FizzBuzz")]
        [InlineData(76, "76")]
        [InlineData(77, "77")]
        [InlineData(78, "Fizz")]
        [InlineData(79, "79")]
        [InlineData(80, "Buzz")]
        [InlineData(81, "Fizz")]
        [InlineData(82, "82")]
        [InlineData(83, "83")]
        [InlineData(84, "Fizz")]
        [InlineData(85, "Buzz")]
        [InlineData(86, "86")]
        [InlineData(87, "Fizz")]
        [InlineData(88, "88")]
        [InlineData(89, "89")]
        [InlineData(90, "FizzBuzz")]
        [InlineData(91, "91")]
        [InlineData(92, "92")]
        [InlineData(93, "Fizz")]
        [InlineData(94, "94")]
        [InlineData(95, "Buzz")]
        [InlineData(96, "Fizz")]
        [InlineData(97, "97")]
        [InlineData(98, "98")]
        [InlineData(99, "Fizz")]
        [InlineData(100, "Buzz")]
        public void FizzBuzzShouldWork(int num, string expected)
        {
            var runner = new DoFizzBuzz();

            var answer = runner.GetFizzBuzz(num);

            answer.Should().Be(expected);
        }
    }
}
