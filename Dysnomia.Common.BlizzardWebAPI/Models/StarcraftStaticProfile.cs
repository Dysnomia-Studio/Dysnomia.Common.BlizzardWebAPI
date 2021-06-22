﻿using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class StarcraftStaticProfile {
		public IEnumerable<StarcraftStaticProfileAchievement> achievements { get; set; }
		public IEnumerable<StarcraftStaticProfileCriteria> criteria { get; set; }
		public IEnumerable<StarcraftStaticProfileCategory> categories { get; set; }
		public IEnumerable<StarcraftStaticProfileReward> rewards { get; set; }
	}

	public class StarcraftStaticProfileAchievement {
		public string categoryId { get; set; }
		public IEnumerable<string> chainAchievementIds { get; set; }
		public int chainRewardSize { get; set; }
		public IEnumerable<string> criteriaIds { get; set; }
		public string description { get; set; }
		public int flags { get; set; }
		public string id { get; set; }
		public string imageUrl { get; set; }
		public bool isChained { get; set; }
		public int points { get; set; }
		public string title { get; set; }
		public int uiOrderHint { get; set; }
	}

	public class StarcraftStaticProfileCriteria {
		public string achievementId { get; set; }
		public string description { get; set; }
		public string evaluationClass { get; set; }
		public int flags { get; set; }
		public string id { get; set; }
		public int necessaryQuantity { get; set; }
		public int uiOrderHint { get; set; }
	}

	public class StarcraftStaticProfileCategory {
		public IEnumerable<string> childrenCategoryIds { get; set; }
		public string featuredAchievementId { get; set; }
		public string id { get; set; }
		public string name { get; set; }
		public string parentCategoryId { get; set; }
		public int points { get; set; }
		public int uiOrderHint { get; set; }
	}

	public class StarcraftStaticProfileReward {
		public int flags { get; set; }
		public string id { get; set; }
		public string achievementId { get; set; }
		public string name { get; set; }
		public string imageUrl { get; set; }
		public string unlockableType { get; set; }
		public bool isSkin { get; set; }
		public int uiOrderHint { get; set; }
	}
}
