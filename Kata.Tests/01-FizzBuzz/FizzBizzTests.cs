
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(12)]
    [InlineData(51)]
    [InlineData(99)]
    public void SayFizz_ShouldReturnFizz(int number)
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayFizz(number);

        // Assert
        actual.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(13)]
    [InlineData(62)]
    [InlineData(100)]
    public void SayFizz_ShouldNotReturnFizz(int number)
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayFizz(number);

        // Assert
        actual.Should().NotBe("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(20)]
    [InlineData(75)]
    [InlineData(100)]
    public void SayBuzz_ShouldReturnBuzz(int number)
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayBuzz(number);

        // Assert
        actual.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(31)]
    [InlineData(86)]
    [InlineData(99)]
    public void SayBuzz_ShouldNotReturnBuzz(int number)
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayBuzz(number);

        // Assert
        actual.Should().NotBe("Buzz");
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(76, "76")]
    [InlineData(77, "77")]
    [InlineData(78, "Fizz")]
    [InlineData(80, "Buzz")]
    [InlineData(90, "FizzBuzz")]
    public void SayFizzBuzz_ShouldReturnFizzBuzz(int number, string expectedResult)
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayFizzBuzz(number);

        // Assert
        actual.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(101)]
    private void IsNumberValidForOneToOneHundred_ShouldThrowException(int input)
    {
        //Arrange
        var fizzBuzzObj = new FizzBuzz();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => fizzBuzzObj.IsNumberValidForOneToOneHundred(input));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(50)]
    [InlineData(100)]
    private void IsNumberValidForOneToOneHundred_ShouldNotThrowException(int input)
    {
        //Arrange
        var fizzBuzzObj = new FizzBuzz();

        //Act & Assert
        fizzBuzzObj.IsNumberValidForOneToOneHundred(input);
    }
    

    [Fact]
    public void SayFizzBuzzFromOneToOneHundredNumbers_ShouldReturnCompleteFizzBuzz()
    {
        // Arrange
        var fizzBuzzObj = new FizzBuzz();

        // Act
        var actual = fizzBuzzObj.SayFizzBuzzFromOneToOneHundredNumbers();

        // Assert
        actual.Should().Be("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz");
    }
}

