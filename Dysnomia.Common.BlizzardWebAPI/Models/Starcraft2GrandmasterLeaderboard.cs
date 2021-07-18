using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Starcraft2GrandmasterLeaderboard {
		public IEnumerable<Starcraft2GrandmasterLeaderboardLadderTeam> ladderTeams { get; set; }
	}

	public class Starcraft2GrandmasterLeaderboardLadderTeam {
		public IEnumerable<Starcraft2GrandmasterLeaderboardLadderTeamMember> teamMembers { get; set; }
		public int previousRank { get; set; }
		public int points { get; set; }
		public int wins { get; set; }
		public int losses { get; set; }
		public int mmr { get; set; }
		public ulong joinTimestamp { get; set; }
	}

	public class Starcraft2GrandmasterLeaderboardLadderTeamMember {
		public string id { get; set; }
		public int realm { get; set; }
		public int region { get; set; }
		public string displayName { get; set; }
		public string clanTag { get; set; }
		public string favoriteRace { get; set; }
	}
}
