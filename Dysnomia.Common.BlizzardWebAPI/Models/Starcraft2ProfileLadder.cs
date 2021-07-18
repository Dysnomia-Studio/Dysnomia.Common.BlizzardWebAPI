using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Starcraft2ProfileLadder {
		public IEnumerable<dynamic> ladderTeams { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
		public IEnumerable<dynamic> allLadderMemberships { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
		public IEnumerable<dynamic> ranksAndPools { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
	}
}
