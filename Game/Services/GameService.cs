using Game.Contracts.Requests;
using Game.Contracts.Responses;
using Game.Models;
using System.Collections.Concurrent;

namespace Game.Services;

public class GameService
{
    readonly ConcurrentDictionary<Guid, GameState> _games = new();

    public GameService()
    {
    }

    public GameState GetGame(GetGameRequest request)
    {
        return _games[Guid.Parse(request.Id)];
    }

    public StarGameResponse StartGame(StartGameRequest request)
    {
        return new();
    }

    public RevealTileResponse RevealTile(RevealTileRequest request)
    {
        return new();
    }

    public AnswerResponse Answer(AnswerRequest request)
    {
        return new();
    }

    public JoinResponse Join(JoinRequest request)
    {
        return new();
    }
}
