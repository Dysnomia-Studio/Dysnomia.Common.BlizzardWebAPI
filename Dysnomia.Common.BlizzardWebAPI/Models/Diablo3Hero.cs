namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Hero {
		public int id { get; set; }
		public string name { get; set; }
		public string _class { get; set; }
		public int gender { get; set; }
		public int level { get; set; }
		public int paragonLevel { get; set; }
		public Diablo3Kills kills { get; set; }
		public bool hardcore { get; set; }
		public bool seasonal { get; set; }
		public int seasonCreated { get; set; }
		public Diablo3HeroSkills skills { get; set; }
		public Diablo3HeroItems items { get; set; }
		public Diablo3HeroFollowers followers { get; set; }
		public Diablo3HeroLegendarypower[] legendaryPowers { get; set; }
		public Diablo3HeroFollowerProgression progression { get; set; }
		public bool alive { get; set; }
		public int lastUpdated { get; set; }
		public int highestSoloRiftCompleted { get; set; }
		public Diablo3HeroStats stats { get; set; }
	}

	public class Diablo3HeroSkills {
		public Diablo3HeroActiveSkills[] active { get; set; }
		public Diablo3HeroPassiveSkills[] passive { get; set; }
	}

	public class Diablo3HeroActiveSkills {
		public Diablo3HeroSkill skill { get; set; }
		public Diablo3HeroActiveSkillRune rune { get; set; }
	}

	public class Diablo3HeroActiveSkillRune {
		public string slug { get; set; }
		public string type { get; set; }
		public string name { get; set; }
		public int level { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}

	public class Diablo3HeroPassiveSkills {
		public Diablo3HeroSkill skill { get; set; }
	}
	public class Diablo3HeroSkill {
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int level { get; set; }
		public string tooltipUrl { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
		public string flavorText { get; set; }
	}

	public class Diablo3HeroItems {
		public Diablo3HeroItem head { get; set; }
		public Diablo3HeroItem neck { get; set; }
		public Diablo3HeroItem torso { get; set; }
		public Diablo3HeroItem shoulders { get; set; }
		public Diablo3HeroItem legs { get; set; }
		public Diablo3HeroItem waist { get; set; }
		public Diablo3HeroItem hands { get; set; }
		public Diablo3HeroItem bracers { get; set; }
		public Diablo3HeroItem feet { get; set; }
		public Diablo3HeroItem leftFinger { get; set; }
		public Diablo3HeroItem rightFinger { get; set; }
		public Diablo3HeroItem mainHand { get; set; }
		public Diablo3HeroItem offHand { get; set; }
		public Diablo3HeroItem special { get; set; }
	}

	public class Diablo3HeroItem {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
		public Diablo3HeroItemTransmo transmogItem { get; set; }
	}

	public class Diablo3HeroItemTransmo {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
	}

	public class Diablo3HeroFollowers {
		public Diablo3HeroFollower templar { get; set; }
		public Diablo3HeroFollower scoundrel { get; set; }
		public Diablo3HeroFollower enchantress { get; set; }
	}

	public class Diablo3HeroFollower {
		public string slug { get; set; }
		public int level { get; set; }
		public Diablo3HeroItems items { get; set; }
		public Diablo3HeroFollowerStats stats { get; set; }
		public object[] skills { get; set; }
	}

	public class Diablo3HeroFollowerStats {
		public float goldFind { get; set; }
		public float magicFind { get; set; }
		public float experienceBonus { get; set; }
	}

	public class Diablo3HeroFollowerProgression {
		public Diablo3HeroFollowerProgressionAct act1 { get; set; }
		public Diablo3HeroFollowerProgressionAct act2 { get; set; }
		public Diablo3HeroFollowerProgressionAct act3 { get; set; }
		public Diablo3HeroFollowerProgressionAct act4 { get; set; }
		public Diablo3HeroFollowerProgressionAct act5 { get; set; }
	}

	public class Diablo3HeroFollowerProgressionAct {
		public bool completed { get; set; }
		public Diablo3HeroFollowerProgressionActCompletedquest[] completedQuests { get; set; }
	}

	public class Diablo3HeroFollowerProgressionActCompletedquest {
		public string slug { get; set; }
		public string name { get; set; }
	}

	public class Diablo3HeroStats {
		public float life { get; set; }
		public float damage { get; set; }
		public float toughness { get; set; }
		public float healing { get; set; }
		public float attackSpeed { get; set; }
		public float armor { get; set; }
		public float strength { get; set; }
		public float dexterity { get; set; }
		public float vitality { get; set; }
		public float intelligence { get; set; }
		public float physicalResist { get; set; }
		public float fireResist { get; set; }
		public float coldResist { get; set; }
		public float lightningResist { get; set; }
		public float poisonResist { get; set; }
		public float arcaneResist { get; set; }
		public float blockChance { get; set; }
		public float blockAmountMin { get; set; }
		public float blockAmountMax { get; set; }
		public float goldFind { get; set; }
		public float critChance { get; set; }
		public float thorns { get; set; }
		public float lifeSteal { get; set; }
		public float lifePerKill { get; set; }
		public float lifeOnHit { get; set; }
		public float primaryResource { get; set; }
		public float secondaryResource { get; set; }
	}

	public class Diablo3HeroLegendarypower {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
	}
}
