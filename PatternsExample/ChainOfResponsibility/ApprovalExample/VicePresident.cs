namespace PatternsExample.ChainOfResponsibility.ApprovalExample;

public sealed class VicePresident : Approver
{
    public override string ProcessPurchase(PurchaseDto purchaseDto)
    {
        if (purchaseDto.Amount < 25000)
        {
            return $"Approved by {GetType().Name} for purchase {purchaseDto}";
        }
        else
        {
            return Successor?.ProcessPurchase(purchaseDto) ?? "There is no approver for the next level";
        }
    }
}