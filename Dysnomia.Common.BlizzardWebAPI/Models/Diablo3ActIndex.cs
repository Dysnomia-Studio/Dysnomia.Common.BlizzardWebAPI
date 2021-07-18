using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3ActIndex {
		public IEnumerable<Diablo3Act> acts { get; set; }
	}

	public class Diablo3Act {
		public string slug { get; set; }
		public int number { get; set; }
		public string name { get; set; }
		public IEnumerable<Diablo3ActQuest> quests { get; set; }
	}

	public class Diablo3ActQuest {
		public int id { get; set; }
		public string name { get; set; }
		public string slug { get; set; }
	}
}
