using System;
using System.Collections;
using System.Collections.Generic;
using APBDKolokwium2.Models;

namespace APBDKolokwium2.Services
{
    public interface IChampionshipsDbService
    {
        public ICollection<ResponseTeam> GetTeams(int IdChampionship);
        public String AddPlayerToTeam(int IdTeam, Player player);
    }
}