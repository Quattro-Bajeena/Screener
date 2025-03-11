using Core;

namespace Game.Consts;

public static class GameRoutes
{
    public const string GameRoom = "/gameroom/{id}";
    public const string BrowseRooms = "/roomBrowser";
    public const string ApiGame = $"{Routes.Api}/game";
    public const string GetGame = $"{ApiGame}/get";
    public const string ApiStartGame = $"{ApiGame}/start";
    public const string ApiRevealTile = $"{ApiGame}/reveal";
    public const string ApiAnswer = $"{ApiGame}/answer";
    public const string JoinRoom = $"{ApiGame}/joinroom";
    public const string GetRooms = $"{ApiGame}/getrooms";
    public const string CreateRoom = $"{ApiGame}/createroom";
    public const string GetRoom = $"{ApiGame}/getroom";
}
