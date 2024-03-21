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
        /// Represent one team in a matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent the score of this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represent the matchup that this team came 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        
    }
}
