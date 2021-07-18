using System.Collections.Generic;

namespace Dysnomia.Common.BlizzardWebAPI.Models {
	public class Diablo3Artisan {
		public string slug { get; set; }
		public string name { get; set; }
		public string portrait { get; set; }
		public Diablo3ArtisanTraining training { get; set; }
	}

	public class Diablo3ArtisanTraining {
		public IEnumerable<Diablo3ArtisanTrainingTier> tiers { get; set; }
	}

	public class Diablo3ArtisanTrainingTier {
		public int tier { get; set; }

		public IEnumerable<Diablo3ArtisanTrainingTierRecipe> trainedRecipes { get; set; }
		public IEnumerable<Diablo3ArtisanTrainingTierRecipe> taughtRecipes { get; set; }
	}

	public class Diablo3ArtisanTrainingTierRecipe {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public int cost { get; set; }
		public IEnumerable<Diablo3ArtisanTrainingTierRecipeItem> reagents { get; set; }
		public Diablo3ArtisanTrainingTierRecipeItem itemProduced { get; set; }
	}

	public class Diablo3ArtisanTrainingTierRecipeItem {
		public string id { get; set; }
		public string slug { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string path { get; set; }
	}
}
