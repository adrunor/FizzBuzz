namespace FizzBuzz;

[TestClass]
public class FizzBuzzTest
{
    [TestMethod]
    public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five()
    {
        const int number = 1;
            
        var fizzBuzz = new FizzBuzzPrinter();
        var value = fizzBuzz.Print(number);

        Assert.Equals("1", value);
    }
}