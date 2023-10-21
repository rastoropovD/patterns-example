namespace PatternsExample.ChainOfResponsibility.ApprovalExample;

public sealed class President : Approver
{
    public override string ProcessPurchase(PurchaseDto purchaseDto)
    {
        if (purchaseDto.Amount < 100000)
        {
            return $"Approved by {GetType().Name} for purchase {purchaseDto}";
        }
        else
        {
            return Successor?.ProcessPurchase(purchaseDto) ?? "There is no approver for the next level";
        }
    }
}