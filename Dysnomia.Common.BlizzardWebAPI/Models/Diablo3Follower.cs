using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Follower {
		public string slug { get; set; }
		public string name { get; set; }
		public string realName { get; set; }
		public string portrait { get; set; }
		public IEnumerable<Diablo3FollowerSkills> skills { get; set; }
	}

	public class Diablo3FollowerSkills {
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int level { get; set; }
		public string tooltipUrl { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}
}
