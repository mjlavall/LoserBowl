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
        public bool Selected { get; set; }
        public virtual ICollection<Game> Schedule { get; set; }

    }
}
