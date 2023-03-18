namespace MyCollections;

public class PrimeFactors
{
    public List<int> Generate(int number)
    {
        var factors = new List<int>();
        if (number > 1)
            factors.Add(number);
        return factors;
    }
}