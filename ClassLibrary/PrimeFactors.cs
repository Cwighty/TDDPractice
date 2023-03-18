namespace MyCollections;

public class PrimeFactors
{
    public static List<int> Generate(int number)
    {
        var factors = new List<int>();
        if (number > 1)
        {
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }
        }
        if (number > 1)
            factors.Add(number);
        return factors;
    }
}