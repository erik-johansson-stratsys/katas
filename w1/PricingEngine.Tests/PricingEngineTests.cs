namespace PricingEngineTests;

public class PricingEngineTests
{
    [TestCase(100, CustomerType.Individual, null, 1, 100.00)]
    [TestCase(100, CustomerType.Business, null, 1, 90.00)]
    [TestCase(100, CustomerType.Nonprofit, null, 1, 80.00)]
    [TestCase(100, CustomerType.Individual, "SAVE15", 1, 85.00)]
    [TestCase(100, CustomerType.Business, "SAVE15", 1, 76.50)]
    [TestCase(100, CustomerType.Business, "SAVE15", 12, 72.68)]
    [TestCase(100, CustomerType.Individual, null, 12, 95.00)]
    public void Calculate_ReturnsExpectedPrice(
        decimal basePrice, CustomerType customerType, string? promoCode, int months, decimal expected)
    {
        var request = new PricingRequest(basePrice, customerType, promoCode, months);

        var result = PricingEngine.Calculate(request);

        Assert.That(result, Is.EqualTo(expected));
    }
}
