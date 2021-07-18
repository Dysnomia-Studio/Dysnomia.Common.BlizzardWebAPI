using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Starcraft2ProfileLadderSummary {
		public IEnumerable<dynamic> showCaseEntries { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
		public IEnumerable<dynamic> placementMatches { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
		public IEnumerable<dynamic> allLadderMemberships { get; set; } // TODO: find a user to define structures, Elanis doesn't have data when calling APIs
	}
}
