using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class StarcraftProfile {
		public StarcraftProfileSummary summary { get; set; }
		public StarcraftProfileSnapShot snapshot { get; set; }
		public StarcraftProfileCareer career { get; set; }
		public StarcraftProfileSwarmLevels swarmLevels { get; set; }
		public StarcraftProfileCampaign campaign { get; set; }
		public IEnumerable<StarcraftProfileCategoryPointProgressItem> categoryPointProgress { get; set; }
		public IEnumerable<string> achievementShowcase { get; set; }
		public IEnumerable<StarcraftProfileReward> earnedRewards { get; set; }
		public IEnumerable<StarcraftProfileAchievement> earnedAchievements { get; set; }
	}

	public class StarcraftProfileSummary {
		public string id { get; set; }
		public int realm { get; set; }
		public string displayName { get; set; }
		public string portrait { get; set; }
		public string decalTerran { get; set; }
		public string decalProtoss { get; set; }
		public string decalZerg { get; set; }
		public int totalSwarmLevel { get; set; }
		public int totalAchievementPoints { get; set; }
	}

	public class StarcraftProfileSnapShot {
		public Dictionary<string, StarcraftProfileSnapShotItem> seasonSnapshot { get; set; }
		public int totalRankedSeasonGamesPlayed { get; set; }
	}

	public class StarcraftProfileSnapShotItem {
		public int rank { get; set; }
		public string leagueName { get; set; }
		public int totalGames { get; set; }
		public int totalWins { get; set; }
	}

	public class StarcraftProfileCareer {
		public int terranWins { get; set; }
		public int zergWins { get; set; }
		public int protossWins { get; set; }
		public int totalCareerGames { get; set; }
		public int totalGamesThisSeason { get; set; }
		public string current1v1LeagueName { get; set; }
		public string currentBestTeamLeagueName { get; set; }

		public StarcraftProfileCareerItem best1v1Finish { get; set; }
		public StarcraftProfileCareerItem bestTeamFinish { get; set; }
	}

	public class StarcraftProfileCareerItem {
		public string leagueName { get; set; }
		public int timesAchieved { get; set; }
	}

	public class StarcraftProfileSwarmLevels {
		public int level { get; set; }
		public StarcraftProfileSwarmLevelsItem terran { get; set; }
		public StarcraftProfileSwarmLevelsItem zerg { get; set; }
		public StarcraftProfileSwarmLevelsItem protoss { get; set; }
	}

	public class StarcraftProfileSwarmLevelsItem {
		public int level { get; set; }
		public int maxLevelPoints { get; set; }
		public int currentLevelPoints { get; set; }
	}

	public class StarcraftProfileCampaign {
		public Dictionary<string, string> difficultyCompleted { get; set; }
	}

	public class StarcraftProfileCategoryPointProgressItem {
		public string categoryId { get; set; }
		public int pointsEarned { get; set; }
	}

	public class StarcraftProfileReward {
		public string rewardId { get; set; }
		public string achievementId { get; set; }
		public bool selected { get; set; }
	}

	public class StarcraftProfileAchievement {
		public string achievementId { get; set; }
		public decimal completionDate { get; set; } // I once got "-9223372036854776000" as value, so, no uint64/int64 here :/
		public int numCompletedAchievementsInSeries { get; set; }
		public int totalAchievementsInSeries { get; set; }
		public bool isComplete { get; set; }
		public bool inProgress { get; set; }
		public IEnumerable<StarcraftProfileAchievementCriteria> criteria { get; set; }
	}

	public class StarcraftProfileAchievementCriteria {
		public string criterionId { get; set; }
	}
}
