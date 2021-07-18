using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Starcraft2Profile {
		public Starcraft2ProfileSummary summary { get; set; }
		public Starcraft2ProfileSnapShot snapshot { get; set; }
		public Starcraft2ProfileCareer career { get; set; }
		public Starcraft2ProfileSwarmLevels swarmLevels { get; set; }
		public Starcraft2ProfileCampaign campaign { get; set; }
		public IEnumerable<Starcraft2ProfileCategoryPointProgressItem> categoryPointProgress { get; set; }
		public IEnumerable<string> achievementShowcase { get; set; }
		public IEnumerable<Starcraft2ProfileReward> earnedRewards { get; set; }
		public IEnumerable<Starcraft2ProfileAchievement> earnedAchievements { get; set; }
	}

	public class Starcraft2ProfileSummary {
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

	public class Starcraft2ProfileSnapShot {
		public Dictionary<string, Starcraft2ProfileSnapShotItem> seasonSnapshot { get; set; }
		public int totalRankedSeasonGamesPlayed { get; set; }
	}

	public class Starcraft2ProfileSnapShotItem {
		public int rank { get; set; }
		public string leagueName { get; set; }
		public int totalGames { get; set; }
		public int totalWins { get; set; }
	}

	public class Starcraft2ProfileCareer {
		public int terranWins { get; set; }
		public int zergWins { get; set; }
		public int protossWins { get; set; }
		public int totalCareerGames { get; set; }
		public int totalGamesThisSeason { get; set; }
		public string current1v1LeagueName { get; set; }
		public string currentBestTeamLeagueName { get; set; }

		public Starcraft2ProfileCareerItem best1v1Finish { get; set; }
		public Starcraft2ProfileCareerItem bestTeamFinish { get; set; }
	}

	public class Starcraft2ProfileCareerItem {
		public string leagueName { get; set; }
		public int timesAchieved { get; set; }
	}

	public class Starcraft2ProfileSwarmLevels {
		public int level { get; set; }
		public Starcraft2ProfileSwarmLevelsItem terran { get; set; }
		public Starcraft2ProfileSwarmLevelsItem zerg { get; set; }
		public Starcraft2ProfileSwarmLevelsItem protoss { get; set; }
	}

	public class Starcraft2ProfileSwarmLevelsItem {
		public int level { get; set; }
		public int maxLevelPoints { get; set; }
		public int currentLevelPoints { get; set; }
	}

	public class Starcraft2ProfileCampaign {
		public Dictionary<string, string> difficultyCompleted { get; set; }
	}

	public class Starcraft2ProfileCategoryPointProgressItem {
		public string categoryId { get; set; }
		public int pointsEarned { get; set; }
	}

	public class Starcraft2ProfileReward {
		public string rewardId { get; set; }
		public string achievementId { get; set; }
		public bool selected { get; set; }
	}

	public class Starcraft2ProfileAchievement {
		public string achievementId { get; set; }
		public decimal completionDate { get; set; } // I once got "-9223372036854776000" as value, so, no uint64/int64 here :/
		public int numCompletedAchievementsInSeries { get; set; }
		public int totalAchievementsInSeries { get; set; }
		public bool isComplete { get; set; }
		public bool inProgress { get; set; }
		public IEnumerable<Starcraft2ProfileAchievementCriteria> criteria { get; set; }
	}

	public class Starcraft2ProfileAchievementCriteria {
		public string criterionId { get; set; }
	}
}
