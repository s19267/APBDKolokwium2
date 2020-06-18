using System;
using System.Collections.Generic;

namespace APBDKolokwium2.Models
{
    public class Player
    {
        public int IdPlayer { get; set; }
        
        public String FirstName { get; set; }
        
        public String LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public ICollection<PlayerTeam> PlayerTeams { get; set; }
    }
}