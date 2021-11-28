using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Account {
		public string battleTag { get; set; }
		public int paragonLevel { get; set; }
		public int paragonLevelHardcore { get; set; }
		public int paragonLevelSeason { get; set; }
		public int paragonLevelSeasonHardcore { get; set; }
		public string guildName { get; set; }
		public Diablo3AccountHero[] heroes { get; set; }
		public int lastHeroPlayed { get; set; }
		public int lastUpdated { get; set; }
		public Dictionary<string, int> kills { get; set; }
		public int highestHardcoreLevel { get; set; }
		public Dictionary<string, float> timePlayed { get; set; }
		public Diablo3AccountProgression progression { get; set; }
		public Dictionary<string, Diablo3AccountSeason> seasonalProfiles { get; set; }
		public Diablo3AccountFollowerStats blacksmith { get; set; }
		public Diablo3AccountFollowerStats jeweler { get; set; }
		public Diablo3AccountFollowerStats mystic { get; set; }
		public Diablo3AccountFollowerStats blacksmithSeason { get; set; }
		public Diablo3AccountFollowerStats jewelerSeason { get; set; }
		public Diablo3AccountFollowerStats mysticSeason { get; set; }
		public Diablo3AccountFollowerStats blacksmithHardcore { get; set; }
		public Diablo3AccountFollowerStats jewelerHardcore { get; set; }
		public Diablo3AccountFollowerStats mysticHardcore { get; set; }
		public Diablo3AccountFollowerStats blacksmithSeasonHardcore { get; set; }
		public Diablo3AccountFollowerStats jewelerSeasonHardcore { get; set; }
		public Diablo3AccountFollowerStats mysticSeasonHardcore { get; set; }
	}

	public class Diablo3AccountProgression {
		public bool act1 { get; set; }
		public bool act2 { get; set; }
		public bool act3 { get; set; }
		public bool act4 { get; set; }
		public bool act5 { get; set; }
	}

	public class Diablo3AccountSeason {
		public int seasonId { get; set; }
		public int paragonLevel { get; set; }
		public int paragonLevelHardcore { get; set; }
		public Diablo3Kills kills { get; set; }
		public Diablo3AccountTimeplayed timePlayed { get; set; }
		public int highestHardcoreLevel { get; set; }
	}

	public class Diablo3AccountTimeplayed {
		public float demonhunter { get; set; }
		public float barbarian { get; set; }
		public float witchdoctor { get; set; }
		public float necromancer { get; set; }
		public float wizard { get; set; }
		public float monk { get; set; }
		public float crusader { get; set; }
	}

	public class Diablo3AccountFollowerStats {
		public string slug { get; set; }
		public int level { get; set; }
	}

	public class Diablo3AccountHero {
		public int id { get; set; }
		public string name { get; set; }
		public string _class { get; set; }
		public string classSlug { get; set; }
		public int gender { get; set; }
		public int level { get; set; }
		public Diablo3Kills kills { get; set; }
		public int paragonLevel { get; set; }
		public bool hardcore { get; set; }
		public bool seasonal { get; set; }
		public bool dead { get; set; }
		public int lastupdated { get; set; }
	}
}
