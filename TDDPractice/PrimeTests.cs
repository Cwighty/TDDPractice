using MyCollections;

namespace TDDPractice;

public class PrimeTests
{
    [SetUp]
    public void Setup()
    {

    }
    [Test]
    public void PrimeFactorsOf1()
    {
        var result = PrimeFactors.Generate(1);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void PrimeFactorsOf2()
    {
        var result = PrimeFactors.Generate(2);
        Assert.That(result, Is.EqualTo(new List<int> { 2 }));
    }

    [Test]
    public void PrimeFactorsOf3()
    {
        var result = PrimeFactors.Generate(3);
        Assert.That(result, Contains.Item(3));
    }

    [Test]
    public void PrimeFactorsOf4to7()
    {
        var result = PrimeFactors.Generate(4);
        Assert.That(result, Is.EqualTo(new List<int> { 2, 2 }));
        result = PrimeFactors.Generate(5);
        Assert.That(result, Is.EqualTo(new List<int> { 5 }));
        result = PrimeFactors.Generate(6);
        Assert.That(result, Is.EqualTo(new List<int> { 2, 3 }));
        result = PrimeFactors.Generate(7);
        Assert.That(result, Is.EqualTo(new List<int> { 7 }));
    }

    [Test]
    public void PrimeFactorsOf8()
    {
        var result = PrimeFactors.Generate(8);
        Assert.That(result, Is.EqualTo(new List<int> { 2, 2, 2 }));
    }

    [Test]
    public void PrimeFactorsOf9()
    {
        var result = PrimeFactors.Generate(9);
        Assert.That(result, Is.EqualTo(new List<int> { 3, 3 }));
    }
}