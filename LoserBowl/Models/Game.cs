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
    }
}
