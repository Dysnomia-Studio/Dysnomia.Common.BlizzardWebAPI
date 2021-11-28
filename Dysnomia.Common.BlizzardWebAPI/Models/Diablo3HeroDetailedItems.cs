namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3HeroDetailedItems {
		public Diablo3HeroDetailedItem head { get; set; }
		public Diablo3HeroDetailedItem neck { get; set; }
		public Diablo3HeroDetailedItem torso { get; set; }
		public Diablo3HeroDetailedItem shoulders { get; set; }
		public Diablo3HeroDetailedItem legs { get; set; }
		public Diablo3HeroDetailedItem waist { get; set; }
		public Diablo3HeroDetailedItem hands { get; set; }
		public Diablo3HeroDetailedItem bracers { get; set; }
		public Diablo3HeroDetailedItem feet { get; set; }
		public Diablo3HeroDetailedItem leftFinger { get; set; }
		public Diablo3HeroDetailedItem rightFinger { get; set; }
		public Diablo3HeroDetailedItem mainHand { get; set; }
		public Diablo3HeroDetailedItem offHand { get; set; }
	}

	public class Diablo3HeroDetailedItem {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
		public int requiredLevel { get; set; }
		public int itemLevel { get; set; }
		public int stackSizeMax { get; set; }
		public bool accountBound { get; set; }
		public string flavorText { get; set; }
		public string typeName { get; set; }
		public Diablo3HeroDetailedItemType type { get; set; }
		public float armor { get; set; }
		public float attacksPerSecond { get; set; }
		public float minDamage { get; set; }
		public float maxDamage { get; set; }
		public string slots { get; set; }
		public Diablo3HeroDetailedItemAttributes attributes { get; set; }
		public Diablo3HeroDetailedItemAttributes attributesHtml { get; set; }
		public int openSockets { get; set; }
		public Diablo3HeroDetailedItemGem[] gems { get; set; }
		public Diablo3HeroDetailedItemSet set { get; set; }
		public int seasonRequiredToDrop { get; set; }
		public Diablo3HeroDetailedItemTransmog transmog { get; set; }
		public bool isSeasonRequiredToDrop { get; set; }
	}

	public class Diablo3HeroDetailedItemType {
		public bool twoHanded { get; set; }
		public string id { get; set; }
	}

	public class Diablo3HeroDetailedItemAttributes {
		public string[] primary { get; set; }
		public string[] secondary { get; set; }
	}

	public class Diablo3HeroDetailedItemGem {
		public Diablo3HeroDetailedItemGemItem item { get; set; }
		public string[] attributes { get; set; }
		public bool isGem { get; set; }
		public bool isJewel { get; set; }
	}

	public class Diablo3HeroDetailedItemGemItem {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string path { get; set; }
	}


	public class Diablo3HeroDetailedItemSet {
		public string name { get; set; }
		public string slug { get; set; }
		public string description { get; set; }
		public string descriptionHtml { get; set; }
	}

	public class Diablo3HeroDetailedItemTransmog {
		public string id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string displayColor { get; set; }
		public string tooltipParams { get; set; }
	}
}
