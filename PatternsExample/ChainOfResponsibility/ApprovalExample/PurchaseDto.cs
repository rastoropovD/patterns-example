namespace PatternsExample.ChainOfResponsibility.ApprovalExample;

public sealed record PurchaseDto
{
    public int Number { get; }
    public decimal Amount { get; }
    public string Purpose { get; }

    public PurchaseDto(int number, decimal amount, string purpose)
    {
        Number = number;
        Amount = amount;
        Purpose = purpose;
    }
}