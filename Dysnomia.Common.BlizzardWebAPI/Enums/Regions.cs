namespace Dysnomia.Common.BlizzardWebAPI.Enums {
	public enum RegionEnum {
		US = 1, // United States
		EU = 2, // Europe
		KO_TW = 3, // Korea and Taiwan
		CN = 5, // China
	}

	public class StrRegionEnum {
		public const string US = "us";
		public const string UnitedStates = "us";

		public const string EU = "eu";
		public const string Europe = "eu";

		public const string KR = "kr";
		public const string Korea = "kr";

		public const string TW = "tw";
		public const string Taiwan = "tw";

		public const string CN = "cn";
		public const string China = "cn";
	}

	public enum StarCraft2RegionEnum {
		US = 1,
		LatAm = 1,
		Europe = 2,
		Russia = 2,
		Korea = 3,
		Taiwan = 3,
		China = 5
	}

	public enum StarCraft2RealmEnum {
		US = 1,
		LatAm = 2,
		Europe = 1,
		Russia = 2,
		Korea = 1,
		Taiwan = 2,
		China = 1
	}
}
