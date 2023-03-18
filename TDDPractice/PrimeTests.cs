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
        Assert.That(result, Is.EqualTo(new List<int> { 2 }));
    }

    [Test]
    public void PrimeFactorsOf3()
    {
        var primeFactors = new PrimeFactors();
        var result = primeFactors.Generate(3);
        Assert.That(result, Contains.Item(3));
    }

    [Test]
    public void PrimeFactorsOf4()
    {
        var primeFactors = new PrimeFactors();
        var result = primeFactors.Generate(4);
        Assert.That(result, Is.EqualTo(new List<int> { 2, 2 }));
    }
}