using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public Lsit<MatchupEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        public TeamModel winner { get; set; }
        public int MatchupRound { get; set; }

    }
}
