using APBDKolokwium2.Models;

namespace APBDKolokwium2
{
    public class ResponseTeam
    {

        public ResponseTeam(Team team, float score)
        {
            Team = team;
            Score = score;
        }

        public Team Team { get; set; }
        public float Score { get; set; }
    }
}