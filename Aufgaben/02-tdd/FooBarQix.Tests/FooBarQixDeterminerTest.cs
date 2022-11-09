using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(8, "8")]
        public void Determine_WhenNumberIsNotDividableThroughThreeFiveOrSeven_ShouldReturnNumberAsString(int number, string expectedResult)
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Determine_WhenNumberIsDividableTroughThree_ShouldReturnFoo(int number)
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();

            var result = fooBarQixDeterminer.Determine(number);
            
            Assert.Equal("foo", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Determine_WhenNumberIsDividableTroughFive_ShouldReturnBar(int number)
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();

            var result = fooBarQixDeterminer.Determine(number);
            
            Assert.Equal("bar", result);
        }
        
        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(28)]
        public void Determine_WhenNumberIsDividableTroughSeven_ShouldReturnQix(int number)
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();

            var result = fooBarQixDeterminer.Determine(number);
            
            Assert.Equal("qix", result);
        }
        
        [Theory]
        [InlineData(15, "foobar")]
        public void Determine_WhenNumberIsDividableTroughMultipleOfThreeFiveOrSeven_ShouldReturnMultyple(int number, string expectedResult)
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }
    }
}