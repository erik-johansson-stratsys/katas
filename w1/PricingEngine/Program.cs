// The challenge
// You're implementing a pricing engine for a small SaaS billing system.

// Given a subscription price, customer type, promotional code, and subscription duration, calculate the final price.

// These rules apply:
// Rule	Discount
// Business customer	10%
// Nonprofit customer	20%
// Promo code SAVE15	15%
// Subscription for 12+ months	5%

// All applicable discounts are applied sequentially, multiplying the price by the remaining percentage. The order doesn't affect the result under the exercise's rounding rules.

// For example, a business customer using SAVE15 receives a total effective discount of 23.5%, not 25%.

// Use decimal arithmetic and round only the final result to two decimal places, using MidpointRounding.AwayFromZero.

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
