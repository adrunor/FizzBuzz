namespace FizzBuzz;

public class FizzBuzzPrinter
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    
    private const int FizzMultiplier = 3;
    private const int BuzzMultiplier = 5;
        
    public string Print(int number)
    {
        if (number % FizzMultiplier == 0 && number % BuzzMultiplier == 0)
        {
            return Fizz + Buzz;
        }
        if (number % BuzzMultiplier == 0)
        {
            return Buzz;
        }
        if (number % FizzMultiplier == 0)
        {
            return Fizz;
        }
        return number.ToString();
    }
}