namespace PatternsExample.ChainOfResponsibility.BasicExample;

public sealed class HandlerC : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 20 and < 30)
        {
            Console.WriteLine($"{GetType().Name} handled request {request}");
        } 
        else
        {
            Successor?.HandleRequest(request);
        }
    }
}