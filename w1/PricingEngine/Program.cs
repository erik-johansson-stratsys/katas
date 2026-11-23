
Console.WriteLine("Hello, World!");


public enum CustomerType
{
    Individual,
    Business,
    Nonprofit
}

public record PricingRequest(
    decimal BasePrice,
    CustomerType CustomerType,
    string? PromoCode,
    int SubscriptionMonths
);

public static class PricingEngine
{
    public static decimal Calculate(PricingRequest request)
    {

        throw new NotImplementedException();
    }
}
