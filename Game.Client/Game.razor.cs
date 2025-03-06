using Core.Client.Services;
using Game.Consts;
using Game.Contracts.Requests;
using Game.Contracts.Responses;
using Game.Models;
using Microsoft.AspNetCore.Components;

namespace Game.Client;

public partial class Game : ComponentBase
{
    [Parameter]
    public string GameId { get; set; }

    private GameState _gameState;

    private readonly ApiClient _client;

    public Game(ApiClient client)
    {
        _client = client;
    }

    protected override async Task OnInitializedAsync()
    {
        GetGameRequest request = new GetGameRequest { Id = GameId };
        GetGameResponse response = await _client.GetAsync<GetGameRequest, GetGameResponse>(GameRoutes.Get, request);
        _gameState = response.State;
    }

}
