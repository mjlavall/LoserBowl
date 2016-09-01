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

        public double Diff
        {
            get
            {
                var home = Teams.Single(t => t.Id == HomeTeamId);
                var away = Teams.Single(t => t.Id == AwayTeamId);
                var homeStrength = home.Strength;
                var awayStrength = away.Strength;
                return Math.Max(homeStrength, awayStrength) - Math.Min(homeStrength, awayStrength);
            }
        }

        public Team Winner
        {
            get
            {
                if (HomeScore > AwayScore) return Teams.Single(t => t.Id == HomeTeamId);
                if (HomeScore < AwayScore) return Teams.Single(t => t.Id == AwayTeamId);
                return null;
            }
        }

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
        public string MatchDisplay
        {
            get
            {
                var home = Teams.Single(t => t.Id == HomeTeamId);
                var away = Teams.Single(t => t.Id == AwayTeamId);
                var loser = home.Strength > away.Strength ? away : home;
                return $"{DayDisplay} {away.AwayName} AT {home.HomeName}" +
            $"  Loser: {loser.Name} Confidence: {Diff}";
            }
        }
        public override string ToString() => $"{Teams.Single(t => t.Id == AwayTeamId)} AT {Teams.Single(t => t.Id == HomeTeamId)}";
    }
}
