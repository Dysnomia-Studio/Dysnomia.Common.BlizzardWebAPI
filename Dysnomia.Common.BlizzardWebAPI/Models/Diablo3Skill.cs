namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Skill {
		public Diablo3SkillSkill skill { get; set; }
		public Diablo3SkillRune[] runes { get; set; }
	}

	public class Diablo3SkillSkill {
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int level { get; set; }
		public string tooltipUrl { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}

	public class Diablo3SkillRune {
		public string slug { get; set; }
		public string type { get; set; }
		public string name { get; set; }
		public int level { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}
}
