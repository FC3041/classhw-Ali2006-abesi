public class Money : IEquatable<Money>
{
    public int Amount { get; set; }
    public string y { get; set; }

    public Money(int x, string y)
    {
        this.Amount = x;
        this.y = y;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount, "USD");
    }

    public bool Equals(Money? other)
    {
        return this.Amount == other.Amount;
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Equals(b);

    }
    public static bool operator !=(Money a, Money b)
    {
        return !a.Equals(b);
    }


}