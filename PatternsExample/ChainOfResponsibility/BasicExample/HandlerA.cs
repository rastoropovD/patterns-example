namespace PatternsExample.ChainOfResponsibility.BasicExample;

public sealed class HandlerA : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 0 and < 10)
        {
            Console.WriteLine($"{GetType().Name} handled request {request}");
        } 
        else
        {
            Successor?.HandleRequest(request);
        }
    }
}