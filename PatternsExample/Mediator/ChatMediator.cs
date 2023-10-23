namespace PatternsExample.Mediator;

public sealed class ChatMediator : IChatMediator
{
    private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

    public void Send(string from, string to, string message)
    {
        if (_participants.TryGetValue(to, out Participant? participant))
        {
            participant?.Receive(from, message);
        }
    }

    public bool Register(Participant participant)
    {
        return _participants.TryAdd(participant.Name, participant);
    }
}