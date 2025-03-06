using Game.Consts;
using Game.Contracts.Requests;
using Game.Contracts.Responses;
using Game.Services;
using Microsoft.AspNetCore.Mvc;

namespace Screener.Controllers
{
    [Route(GameRoutes.ApiGame)]
    public class GameController : Controller
    {
        private readonly GameService _gameService;
        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(GameRoutes.Get)]
        public IActionResult Get([FromQuery] GetGameRequest request)
        {
            GetGameResponse response = _gameService.GetGame(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiStartGame)]
        public IActionResult StartGame(StartGameRequest request)
        {
            StarGameResponse response = _gameService.StartGame(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiRevealTile)]
        public IActionResult RevealTile(RevealTileRequest request)
        {
            RevealTileResponse response = _gameService.RevealTile(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiAnswer)]
        public IActionResult Answer(AnswerRequest request)
        {
            AnswerResponse response = _gameService.Answer(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiJoin)]
        public IActionResult Join(JoinRequest request)
        {
            JoinResponse response = _gameService.Join(request);
            return Ok(response);
        }
    }
}
