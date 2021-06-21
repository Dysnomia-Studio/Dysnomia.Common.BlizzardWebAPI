using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class SC2PlayerProfile {
		public string id { get; set; }
		public int realm { get; set; }
		public string displayName { get; set; }
		public string clanName { get; set; }
		public string clanTag { get; set; }
		public string profilePath { get; set; }
		public SC2PlayerProfilePortrait portrait { get; set; }
		public SC2PlayerProfileCareer career { get; set; }
		public SC2PlayerProfileSwarmLevels swarmLevels { get; set; }
		public Dictionary<string, string> campaign { get; set; }
		public SC2PlayerProfileSeason season { get; set; }
		public SC2PlayerProfileRewards rewards { get; set; }
		public SC2PlayerProfileAchievements achievements { get; set; }
	}

	public class SC2PlayerProfilePortrait {
		public int x { get; set; }
		public int y { get; set; }
		public int w { get; set; }
		public int h { get; set; }
		public int offset { get; set; }
		public string url { get; set; }
	}

	public class SC2PlayerProfileCareer {
		public string primaryRace { get; set; }
		public int terranWins { get; set; }
		public int protossWins { get; set; }
		public int zergWins { get; set; }
		public string highest1v1Rank { get; set; }
		public string highestTeamRank { get; set; }
		public int seasonTotalGames { get; set; }
		public int careerTotalGames { get; set; }
	}

	public class SC2PlayerProfileSwarmLevels {
		public int level { get; set; }
		public SC2PlayerProfileSwarmLevelsRace terran { get; set; }
		public SC2PlayerProfileSwarmLevelsRace zerg { get; set; }
		public SC2PlayerProfileSwarmLevelsRace protoss { get; set; }
	}

	public class SC2PlayerProfileSwarmLevelsRace {
		public int level { get; set; }
		public int totalLevelXP { get; set; }
		public int currentLevelXP { get; set; }
	}

	public class SC2PlayerProfileSeason {
		public int seasonId { get; set; }
		public int seasonNumber { get; set; }
		public int seasonYear { get; set; }
		public int totalGamesThisSeason { get; set; }
		public IEnumerable<SC2PlayerProfileSeasonStats> stats { get; set; }
	}

	public class SC2PlayerProfileSeasonStats {
		public string type { get; set; }
		public int wins { get; set; }
		public int games { get; set; }
	}

	public class SC2PlayerProfileRewards {
		public IEnumerable<string> selected { get; set; }
		public IEnumerable<string> earned { get; set; }
	}

	public class SC2PlayerProfileAchievements {
		public SC2PlayerProfileAchievementsPoints points { get; set; }
		public IEnumerable<SC2PlayerProfileAchievementsItem> achievements { get; set; }
	}

	public class SC2PlayerProfileAchievementsPoints {
		public ulong totalPoints { get; set; }
		public Dictionary<string, int> categoryPoints { get; set; }
	}

	public class SC2PlayerProfileAchievementsItem {
		public string achievementId { get; set; }
		public int completionDate { get; set; }
	}
}
