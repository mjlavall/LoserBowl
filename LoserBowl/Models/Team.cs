using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoserBowl.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Abbreviation { get; set; }
        public int SeedRank { get; set; }
        public int Selected { get; set; }
        public string Division { get; set; }
        public int PreviousWoL { get; set; }
        public double Handicap { get; set; }
        public virtual ICollection<Game> Games { get; set; }

        private string NameSpaces
        {
            get
            {
                var spaces = "";
                for (var i = Name.Length; i < 10; i++)
                {
                    spaces += " ";
                }
                return spaces;
            }
        }
        public string AwayName => NameSpaces + Name;
        public string HomeName => Name + NameSpaces;
        public double Rank => SeedRank;
        public string RankedDisplay => $"{Rank} {Location} {Name}";
        public override string ToString() => $"{Location} {Name}";

        public int WoL => Wins - Loses;
        public double WinRatio => 1.0*Wins/GamesPlayed;
        public int Wins => Games.Count(g => g.Winner?.Id == Id);
        public int Loses => Games.Count(g => g.Winner != null && g.Winner.Id != Id);
        public int GamesPlayed => Games.Count(g => g.HomeScore > 0 || g.AwayScore > 0);

        public double Strength
        {
            get
            {
                var runningTally = 0.0;
                foreach (var game in Games)
                {
                    var diff = Math.Abs(game.HomeScore - game.AwayScore);
                    var opponent = game.Teams.Single(t => t.Id != Id);
                    if (game.Winner?.Id == Id)
                    {
                        runningTally += diff*opponent.WinRatio;
                    }
                    else if (game.Loser?.Id == Id)
                    {
                        runningTally -= diff/opponent.WinRatio;
                    }
                }
                runningTally /= Math.Max(GamesPlayed, 1);

                return (PreviousWoL/2.0)+(runningTally) -Handicap;
            }
        }

    }
}
