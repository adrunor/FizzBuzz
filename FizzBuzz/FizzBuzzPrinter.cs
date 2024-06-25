namespace FizzBuzz;

public class FizzBuzzPrinter
{
    public string Print(int number)
    {
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}