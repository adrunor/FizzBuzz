namespace FizzBuzz;

public class FizzBuzzPrinter
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    
    private const int FizzMultiplier = 3;
    private const int BuzzMultiplier = 5;
        
    public string Print(int number)
    {
        string? fizzBuzzValue = null;
        if (IsMultipleOf(number, FizzMultiplier))
        {
            fizzBuzzValue += Fizz;
        }
        
        if (IsMultipleOf(number, BuzzMultiplier))
        {
            fizzBuzzValue += Buzz;
        }

        return fizzBuzzValue ?? number.ToString();
    }

    private bool IsMultipleOf(int number, int divider)
    {
        return number % divider == 0;
    }
}