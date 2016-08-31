using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoserBowl.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public string Day { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        private string DaySpaces
        {
            get
            {
                var spaces = "";
                for (var i = Day.Length; i < "Thursday".Length; i++)
                {
                    spaces += " ";
                }
                return spaces;
            }
        }

        public string DayDisplay => Day + DaySpaces;
        public string MatchDisplay => $"{DayDisplay} {Teams.Single(t => t.Id == AwayTeamId).AwayName} AT {Teams.Single(t => t.Id == HomeTeamId).HomeName}";

        public override string ToString() => $"{Teams.Single(t => t.Id == AwayTeamId)} AT {Teams.Single(t => t.Id == HomeTeamId)}";
    }
}
