namespace FizzBuzz;

public class FizzBuzzPrinter
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    
    private const int FizzMultiplier = 3;
    private const int BuzzMultiplier = 5;
        
    public string Print(int number)
    {
        if (IsMultipleOf(number, FizzMultiplier) && IsMultipleOf(number, BuzzMultiplier))
        {
            return Fizz + Buzz;
        }
        
        if (IsMultipleOf(number, BuzzMultiplier))
        {
            return Buzz;
        }
        
        if (IsMultipleOf(number, FizzMultiplier))
        {
            return Fizz;
        }
        return number.ToString();
    }

    private bool IsMultipleOf(int number, int divider)
    {
        return number % divider == 0;
    }
}