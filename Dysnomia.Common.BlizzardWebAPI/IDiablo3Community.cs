using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// Diablo III community APIs provide endpoints for Diablo III player profiles.
	/// https://develop.battle.net/documentation/diablo-3/community-apis
	/// </summary>
	public interface IDiablo3Community {
		/// <summary>
		/// Get image URL from type, size and icon in blizzard CDN
		/// </summary>
		/// <param name="type">The image type (items or skills)</param>
		/// <param name="size">The size: for items must either be small or large; for skills must be 21, 42, or 64 (These values refer to the image size in pixels).</param>
		/// <param name="icon">Icon name without extension</param>
		/// <returns></returns>
		string GetImage(Diablo3ImageType type, string size, string icon);

		/// <summary>
		/// Returns an index of acts.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3ActIndex> GetActIndex(string accessToken, string region, string locale = "en_US");
		/// <summary>
		/// Returns an index of acts.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3ActIndex> GetActIndex(string accessToken, RegionEnum region, string locale = "en_US");

		/// <summary>
		/// Returns a single act by ID.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="actId">The ID of the act to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Act> GetAct(string accessToken, string region, int actId, string locale = "en_US");
		/// <summary>
		/// Returns a single act by ID.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="actId">The ID of the act to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Act> GetAct(string accessToken, RegionEnum region, int actId, string locale = "en_US");

		/// <summary>
		/// Returns a single artisan by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Artisan> GetArtisan(string accessToken, string region, string artisanSlug, string locale = "en_US");
		/// <summary>
		/// Returns a single artisan by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Artisan> GetArtisan(string accessToken, RegionEnum region, Artisan artisanSlug, string locale = "en_US");

		/// <summary>
		/// Returns a single recipe by slug for the specified artisan.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="recipeSlug">The slug of the recipe to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3ArtisanTrainingTierRecipe> GetRecipe(string accessToken, string region, string artisanSlug, string recipeSlug, string locale = "en_US");
		/// <summary>
		/// Returns a single recipe by slug for the specified artisan.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="recipeSlug">The slug of the recipe to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3ArtisanTrainingTierRecipe> GetRecipe(string accessToken, RegionEnum region, Artisan artisanSlug, string recipeSlug, string locale = "en_US");

		/// <summary>
		/// Returns a single follower by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="followerSlug">The slug of the follower to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Follower> GetFollower(string accessToken, string region, string followerSlug, string locale = "en_US");
		/// <summary>
		/// Returns a single follower by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="followerSlug">The slug of the follower to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Diablo3Follower> GetFollower(string accessToken, RegionEnum region, Follower followerSlug, string locale = "en_US");
	}
}
