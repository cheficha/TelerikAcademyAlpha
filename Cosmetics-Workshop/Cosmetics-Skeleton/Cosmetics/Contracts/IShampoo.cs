namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    public interface IShampoo : IProduct
    {
        decimal Militers { get; }
        UsageType Usage { get; }

    }
}