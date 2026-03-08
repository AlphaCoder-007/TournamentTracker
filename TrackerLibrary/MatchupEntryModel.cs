using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for this particaular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup this team came
        /// from as winner.
        /// </summary>
        public MatchupModel ParentMatchup {  get; set; }

        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine();
        }

    }
}
