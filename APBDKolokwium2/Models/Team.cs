using System;
using System.Collections;
using System.Collections.Generic;

namespace APBDKolokwium2.Models
{
    public class Team
    {
        public int IdTeam { get; set; }

        public String TeamName { get; set; }

        public int MaxAge { get; set; }

        public ICollection<ChampionshipTeam> CampionshipTeam { get; set; }

        public ICollection<PlayerTeam> PlayerTeams { get; set; }
    }
}