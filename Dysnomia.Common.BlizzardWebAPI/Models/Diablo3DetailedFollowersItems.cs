namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3DetailedFollowersItems {
		public Diablo3DetailedFollowerItems templar { get; set; }
		public Diablo3DetailedFollowerItems scoundrel { get; set; }
		public Diablo3DetailedFollowerItems enchantress { get; set; }
	}

	public class Diablo3DetailedFollowerItems {
		public Diablo3DetailedFollowerItem neck { get; set; }
		public Diablo3DetailedFollowerItem leftFinger { get; set; }
		public Diablo3DetailedFollowerItem rightFinger { get; set; }
		public Diablo3DetailedFollowerItem mainHand { get; set; }
		public Diablo3DetailedFollowerItem offHand { get; set; }
		public Diablo3DetailedFollowerItem special { get; set; }
	}

	public class Diablo3DetailedFollowerItem {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
		public int requiredLevel { get; set; }
		public int itemLevel { get; set; }
		public int stackSizeMax { get; set; }
		public bool accountBound { get; set; }
		public string typeName { get; set; }
		public Diablo3DetailedFollowerItemType type { get; set; }
		public float armor { get; set; }
		public float attacksPerSecond { get; set; }
		public float minDamage { get; set; }
		public float maxDamage { get; set; }
		public string elementalType { get; set; }
		public string slots { get; set; }
		public Diablo3DetailedFollowerItemAttributes attributes { get; set; }
		public Diablo3DetailedFollowerItemAttributes attributesHtml { get; set; }
		public int openSockets { get; set; }
		public Diablo3DetailedFollowerItemCraftedby craftedBy { get; set; }
		public int seasonRequiredToDrop { get; set; }
		public bool isSeasonRequiredToDrop { get; set; }
	}

	public class Diablo3DetailedFollowerItemType {
		public bool twoHanded { get; set; }
		public string id { get; set; }
	}

	public class Diablo3DetailedFollowerItemAttributes {
		public string[] primary { get; set; }
		public string[] secondary { get; set; }
	}

	public class Diablo3DetailedFollowerItemCraftedby {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public int cost { get; set; }
		public Diablo3DetailedFollowerItemCraftedbyReagent[] reagents { get; set; }
		public Diablo3DetailedFollowerItemCraftedbyItemproduced itemProduced { get; set; }
	}

	public class Diablo3DetailedFollowerItemCraftedbyItemproduced {
		public string id { get; set; }
		public string path { get; set; }
	}

	public class Diablo3DetailedFollowerItemCraftedbyReagent {
		public int quantity { get; set; }
		public Diablo3DetailedFollowerItemCraftedbyReagentItem item { get; set; }
	}

	public class Diablo3DetailedFollowerItemCraftedbyReagentItem {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string path { get; set; }
	}
}
