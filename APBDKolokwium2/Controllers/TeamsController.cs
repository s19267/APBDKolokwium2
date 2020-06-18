using APBDKolokwium2.Models;
using APBDKolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBDKolokwium2.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IChampionshipsDbService _service;

        public TeamsController(IChampionshipsDbService service)
        {
            _service = service;
        }


        [HttpPut("{id:int}/teams")]
        public IActionResult AddPlayerToTeam(int id, Player player)
        {
            var response = _service.AddPlayerToTeam(id, player);
            if (response != null)
                return Ok(response);
            else
                return BadRequest();
        }
    }
}