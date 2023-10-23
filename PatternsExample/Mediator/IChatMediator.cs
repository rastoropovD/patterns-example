namespace PatternsExample.Mediator;

public interface IChatMediator
{
    void Send(string from, string to, string message);

    bool Register(Participant participant);
}