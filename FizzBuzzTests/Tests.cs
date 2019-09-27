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
        public void FizzBuzzShouldWork(int num, string expected)
        {
            var runner = new DoFizzBuzz();

            var answer = runner.GetFizzBuzz(num);

            answer.Should().Be(expected);
        }
    }
}
