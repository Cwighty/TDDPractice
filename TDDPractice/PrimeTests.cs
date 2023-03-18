using MyCollections;

namespace TDDPractice;

public class PrimeTests
{
    [Test]
    public void PrimeFactorsOf1()
    {
        var primeFactors = new PrimeFactors();
        var result = primeFactors.Generate(1);
        Assert.That(result, Is.Empty);
    }

    [Test]
   public void PrimeFactorsOf2()
    {
        var primeFactors = new PrimeFactors();
        var result = primeFactors.Generate(2);
        Assert.That(result, Contains.Item(2));
    }
}