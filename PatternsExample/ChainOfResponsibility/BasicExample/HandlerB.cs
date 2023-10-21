namespace PatternsExample.ChainOfResponsibility.BasicExample;

public sealed class HandlerB : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 10 and < 20)
        {
            Console.WriteLine($"{GetType().Name} handled request {request}");
        } 
        else
        {
            Successor?.HandleRequest(request);
        }
    }
}