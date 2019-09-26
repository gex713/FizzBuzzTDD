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

            var answer = runner.Run();

            answer.Should().Be("1");
        }
    }
}
