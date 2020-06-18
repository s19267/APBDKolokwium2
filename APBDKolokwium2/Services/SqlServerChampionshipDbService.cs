using System.Collections.Generic;
using System.Linq;
using APBDKolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace APBDKolokwium2.Services
{
    public class SqlServerChampionshipDbService :IChampionshipsDbService
    {
        private readonly MyDbContext _context;
        public SqlServerChampionshipDbService(MyDbContext context)
        {
            _context = context;
        }
        
        public ICollection<ResponseTeam> GetTeams(int IdChampionship)
        {
            var championship = _context.Championships.Where(p => p.IdChampionship == IdChampionship).FirstOrDefault();
            var championshipTeams =
                _context.ChampionshipTeams.Where(p => p.IdChampionship == championship.IdChampionship).ToList();
            List<ResponseTeam> teams=new List<ResponseTeam>();

            for (int i = 0; i < championshipTeams.Count; i++)
            {
                var team = _context.Teams.Where(p => p.IdTeam == championshipTeams[i].IdTeam).SingleOrDefault();
                teams.Add(new ResponseTeam(team,championshipTeams[i].Score));
            }

            return teams;
        }

        public string AddPlayerToTeam(int IdTeam, Player player)
        {
            var team = _context.Teams.Where(p => p.IdTeam == IdTeam).SingleOrDefault();
            
                
            

            return null;

        }
    }
}