using System;
using System.Collections;
using System.Collections.Generic;

namespace APBDKolokwium2.Models
{
    public class Championship
    {
        public int IdChampionship { get; set; }

        public String OfficialName { get; set; }

        public int Year { get; set; }

        public ICollection<ChampionshipTeam> CampionshipTeam { get; set; }
    }
}