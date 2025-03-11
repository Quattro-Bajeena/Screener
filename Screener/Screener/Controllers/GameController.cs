using Game.Consts;
using Game.Contracts.Requests;
using Game.Contracts.Responses;
using Game.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Screener.Data;

namespace Screener.Controllers
{
    [Route(GameRoutes.ApiGame)]
    public class GameController : Controller
    {
        private readonly GameService _gameService;
        private readonly UserManager<ApplicationUser> _userManager;
        public GameController(GameService gameService, UserManager<ApplicationUser> userManager)
        {
            _gameService = gameService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return Ok("hello world");
        }

        [HttpGet(GameRoutes.GetGame)]
        public IActionResult Get([FromQuery] GetGameRequest request)
        {
            GetGameResponse response = _gameService.GetGame(request);
            return Ok(response);
        }

        [HttpGet(GameRoutes.GetRooms)]
        public IActionResult GetRooms([FromQuery] GetRoomsRequest request)
        {
            GetRoomsResponse response = _gameService.GetRooms(request);
            return Ok(response);
        }

        [HttpGet(GameRoutes.GetRoom)]
        public IActionResult GetRoom([FromQuery] GetRoomRequest request)
        {
            GetRoomResponse response = _gameService.GetRoom(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.CreateRoom)]
        public async Task<IActionResult> CreateRoom([FromBody] CreateRoomRequest request)
        {
            request.Host = await _userManager.GetUserAsync(User);
            CreateRoomResponse response = _gameService.CreateRoom(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiStartGame)]
        public IActionResult StartGame([FromBody] StartGameRequest request)
        {
            StarGameResponse response = _gameService.StartGame(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiRevealTile)]
        public IActionResult RevealTile([FromBody] RevealTileRequest request)
        {
            RevealTileResponse response = _gameService.RevealTile(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.ApiAnswer)]
        public IActionResult Answer([FromBody] AnswerRequest request)
        {
            AnswerResponse response = _gameService.Answer(request);
            return Ok(response);
        }

        [HttpPost(GameRoutes.JoinRoom)]
        public IActionResult Join([FromBody] JoinRequest request)
        {
            JoinResponse response = _gameService.Join(request);
            return Ok(response);
        }
    }
}
