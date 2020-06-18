using APBDKolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBDKolokwium2.Controllers
{
    [Route("api/championships")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        private readonly IChampionshipsDbService _service;

        public ChampionshipController(IChampionshipsDbService service)
        {
            _service = service;
        }

        [HttpGet("{id:int}/teams")]
        public IActionResult GetTeamsScore(int id)
        {
            var teams = _service.GetTeams(id);
            if (teams != null)
                return Ok(teams);
            else
                return BadRequest();
        }
    }
}