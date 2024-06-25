namespace FizzBuzz;

[TestClass]
public class FizzBuzzTest
{
    [TestMethod]
    public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five()
    {
        var fizzBuzz = new FizzBuzzPrinter();
        
        const int number = 1;

        var value = fizzBuzz.Print(number);

        Assert.AreEqual("1", value);
    }

    [TestMethod]
    public void Should_return_fizz_when_number_is_multiple_of_three()
    {
        var fizzBuzz = new FizzBuzzPrinter();
        
        const int number = 3;

        var value = fizzBuzz.Print(number);
        
        Assert.AreEqual("Fizz", value);
    }

    [TestMethod]
    public void Should_return_buzz_when_number_is_multiple_of_five()
    {
        var fizzBuzz = new FizzBuzzPrinter();

        const int number = 5;

        var value = fizzBuzz.Print(number);
        
        Assert.AreEqual("Buzz", value);
    }
}