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

        public int WoL
        {
            get
            {
                var wins = Games.Count(g => g.Winner?.Id == Id);
                var losses = Games.Count(g => g.Winner != null && g.Winner.Id != Id);
                return wins - losses;
            }
        }

        public double Strength
        {
            get
            {
                double sos = 0;
                int gamesPlayed = 0;
                foreach (var game in Games.ToList())
                {
                    var opponent = game.Teams.Single(t => t.Id != Id);
                    var diff = WoL - opponent.WoL;
                    if (game.Winner?.Id == Id)
                    {
                        sos += diff < 0 ? (-1*diff) : 1/diff;
                        gamesPlayed++;
                    }
                    else if(game.Winner?.Id == opponent.Id)
                    {
                        sos -= diff < 0 ? (-1 * diff) : 1 / diff;
                        gamesPlayed++;
                    }
                }
                sos /= gamesPlayed == 0 ? 1 : gamesPlayed;

                return PreviousWoL+sos;
            }
        }

    }
}
