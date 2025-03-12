using Game.Consts;
using Microsoft.AspNetCore.Components;

namespace Screener.Client.Pages.Game;

[Route(GameRoutes.GameRoom)]
public partial class GameRoomPage
{
    [Parameter]
    public string Id { get; set; }
}