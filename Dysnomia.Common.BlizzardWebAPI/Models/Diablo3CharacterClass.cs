namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3CharacterClass {
		public string slug { get; set; }
		public string name { get; set; }
		public string maleName { get; set; }
		public string femaleName { get; set; }
		public string icon { get; set; }
		public Diablo3CharacterClassSkillCategory[] skillCategories { get; set; }
		public Diablo3CharacterClassSkills skills { get; set; }
	}

	public class Diablo3CharacterClassSkills {
		public Diablo3CharacterClassSkillsActive[] active { get; set; }
		public Diablo3CharacterClassSkillsPassive[] passive { get; set; }
	}

	public class Diablo3CharacterClassSkillsActive {
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int level { get; set; }
		public string tooltipUrl { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}

	public class Diablo3CharacterClassSkillsPassive {
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int level { get; set; }
		public string tooltipUrl { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
		public string flavorText { get; set; }
	}

	public class Diablo3CharacterClassSkillCategory {
		public string slug { get; set; }
		public string name { get; set; }
	}
}
