using Game.Contracts.Requests;
using Game.Contracts.Responses;
using Game.Models;
using System.Collections.Concurrent;

namespace Game.Services;

public class GameService
{
    readonly ConcurrentDictionary<Guid, GameRoom> _rooms = new();

    public GameService()
    {
    }

    public GetGameResponse GetGame(GetGameRequest request)
    {
        return new() { State = _rooms[Guid.Parse(request.Id)].State };
    }

    public GetRoomsResponse GetRooms(GetRoomsRequest request)
    {
        return new() { Rooms = _rooms.Values };
    }

    public GetRoomResponse GetRoom(GetRoomRequest request)
    {
        return new() { Room = _rooms[Guid.Parse(request.Id)] };
    }

    public CreateRoomResponse CreateRoom(CreateRoomRequest request)
    {
        GameRoom newRoom = new()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Private = request.Private,
            Password = request.Password,
            Host = request.Host,
            Rules = request.Rules,
            State = new GameState(),
            Users = [request.Host],
            Images = new GameImageCollection()
            {
                Images = [
                    new GameImage { Path = "img1.jpg", Answers = ["mahoromatic"]},
                    new GameImage { Path = "img2.jpg", Answers = ["godzilla"]},
                    new GameImage { Path = "img3.jpg" , Answers = ["haruhi"]},
                    new GameImage { Path = "img4.jpg" , Answers = ["dynazenon"]},
                ]
            }
        };

        _rooms.TryAdd(newRoom.Id, newRoom);
        return new() { Id = newRoom.Id.ToString() };
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
