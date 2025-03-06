using Core;

namespace Game.Consts;

public static class GameRoutes
{
    public const string Game = "/game";
    public const string ApiGame = $"{Routes.Api}/game";
    public const string Get = $"{ApiGame}/get";
    public const string ApiStartGame = $"{ApiGame}/start";
    public const string ApiRevealTile = $"{ApiGame}/reveal";
    public const string ApiAnswer = $"{ApiGame}/answer";
    public const string ApiJoin = $"{ApiGame}/join";
}
