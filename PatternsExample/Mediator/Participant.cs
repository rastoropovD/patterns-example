namespace PatternsExample.Mediator;

public sealed class Participant
{
    public string Name { get; }

    public Participant(string name)
    {
        Name = name;
    }

    public void Receive(string from, string message)
    {
        Console.WriteLine($"{Name}: got message from '{from}' with value '{message}'");
    }
}