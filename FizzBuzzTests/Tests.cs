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
        public void FizzBuzzShouldWork(int num, string expected)
        {
            var runner = new DoFizzBuzz();

            var answer = runner.GetFizzBuzz(num);

            answer.Should().Be(expected);
        }
    }
}
