namespace Game.Contracts.Requests;

public class AnswerRequest
{
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public string Answer { get; set; }
}
