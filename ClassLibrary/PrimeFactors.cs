namespace MyCollections;

public class PrimeFactors
{
    public List<int> Generate(int number)
    {
        var result = new List<int>();
        if (number > 1)
            result.Add(2);
        return result;
    }
}