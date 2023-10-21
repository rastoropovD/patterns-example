namespace PatternsExample.ChainOfResponsibility.ApprovalExample;

public abstract class Approver
{
    protected Approver? Successor;

    public void SetSuccessor(Approver successor)
    {
        Successor = successor;
    }

    public abstract string ProcessPurchase(PurchaseDto purchaseDto);
}