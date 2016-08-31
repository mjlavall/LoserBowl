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
        public virtual ICollection<Game> Schedule { get; set; }

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


    }
}
