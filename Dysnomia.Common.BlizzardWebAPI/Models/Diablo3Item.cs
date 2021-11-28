namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Item {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string tooltipParams { get; set; }
		public int requiredLevel { get; set; }
		public int stackSizeMax { get; set; }
		public bool accountBound { get; set; }
		public string flavorText { get; set; }
		public string flavorTextHtml { get; set; }
		public string typeName { get; set; }
		public Diablo3ItemSubType type { get; set; }
		public string damage { get; set; }
		public string dps { get; set; }
		public string damageHtml { get; set; }
		public string color { get; set; }
		public bool isSeasonRequiredToDrop { get; set; }
		public int seasonRequiredToDrop { get; set; }
		public string[] slots { get; set; }
		public Diablo3ItemAttributes attributes { get; set; }
		public Diablo3ItemRandomaffix[] randomAffixes { get; set; }
		public object[] setItems { get; set; }
	}

	public class Diablo3ItemSubType {
		public bool twoHanded { get; set; }
		public string id { get; set; }
	}

	public class Diablo3ItemAttributes {
		public Diablo3ItemAttributesPrimary[] primary { get; set; }
		public Diablo3ItemAttributesSecondary[] secondary { get; set; }
		public object[] other { get; set; }
	}

	public class Diablo3ItemAttributesPrimary {
		public string textHtml { get; set; }
		public string text { get; set; }
	}

	public class Diablo3ItemAttributesSecondary {
		public string textHtml { get; set; }
		public string text { get; set; }
	}

	public class Diablo3ItemRandomaffix {
		public Diablo3ItemRandomaffixOneof[] oneOf { get; set; }
	}

	public class Diablo3ItemRandomaffixOneof {
		public string textHtml { get; set; }
		public string text { get; set; }
	}
}
