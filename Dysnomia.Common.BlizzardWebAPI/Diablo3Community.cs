using System;
using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;
using Dysnomia.Common.WebAPIWrapper;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// Diablo III community APIs provide endpoints for Diablo III player profiles.
	/// https://develop.battle.net/documentation/diablo-3/community-apis
	/// </summary>
	public class Diablo3Community : WebAPIQuerier, IDiablo3Community {
		/// <summary>
		/// Get image URL from type, size and icon in blizzard CDN.
		/// Warning: this CDN only supports HTTP, not HTTPS
		/// </summary>
		/// <param name="type">The image type (items or skills)</param>
		/// <param name="size">The size: for items must either be small or large; for skills must be 21, 42, or 64 (These values refer to the image size in pixels).</param>
		/// <param name="icon">Icon name without extension</param>
		/// <returns></returns>
		public string GetImage(Diablo3ImageType type, string size, string icon) {
			if (
				(type == Diablo3ImageType.items && size != "small" && size != "large") ||
				(type == Diablo3ImageType.skills && size != "21" && size != "42" && size != "64")
			) {
				throw new ArgumentException("Invalid icon size: for items must either be small or large; for skills must be 21, 42, or 64 (These values refer to the image size in pixels)");
			}

			return string.Format("http://media.blizzard.com/d3/icons/{0}/{1}/{2}.png", type.ToString(), size, icon);
		}

		/// <summary>
		/// Returns an index of acts.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3ActIndex> GetActIndex(string accessToken, string region, string locale = "en_US") {
			return await this.Get<Diablo3ActIndex>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/act?locale={1}&access_token={2}",
					region, locale, accessToken
				)
			);
		}

		/// <summary>
		/// Returns an index of acts.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3ActIndex> GetActIndex(string accessToken, RegionEnum region, string locale = "en_US") {
			return await GetActIndex(accessToken, region.ToString(), locale);
		}

		/// <summary>
		/// Returns a single act by ID.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="actId">The ID of the act to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Act> GetAct(string accessToken, string region, int actId, string locale = "en_US") {
			return await this.Get<Diablo3Act>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/act/{1}?locale={2}&access_token={3}",
					region, actId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single act by ID.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="actId">The ID of the act to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Act> GetAct(string accessToken, RegionEnum region, int actId, string locale = "en_US") {
			return await GetAct(accessToken, region.ToString(), actId, locale);
		}

		/// <summary>
		/// Returns a single artisan by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Artisan> GetArtisan(string accessToken, string region, string artisanSlug, string locale = "en_US") {
			return await this.Get<Diablo3Artisan>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/artisan/{1}?locale={2}&access_token={3}",
					region, artisanSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single artisan by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Artisan> GetArtisan(string accessToken, RegionEnum region, Artisan artisanSlug, string locale = "en_US") {
			return await GetArtisan(accessToken, region.ToString(), artisanSlug.ToString(), locale);
		}

		/// <summary>
		/// Returns a single recipe by slug for the specified artisan.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="recipeSlug">The slug of the recipe to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3ArtisanTrainingTierRecipe> GetRecipe(string accessToken, string region, string artisanSlug, string recipeSlug, string locale = "en_US") {
			return await this.Get<Diablo3ArtisanTrainingTierRecipe>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/artisan/{1}/recipe/{2}?locale={3}&access_token={4}",
					region, artisanSlug, recipeSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single recipe by slug for the specified artisan.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="artisanSlug">The slug of the artisan to retrieve.</param>
		/// <param name="recipeSlug">The slug of the recipe to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3ArtisanTrainingTierRecipe> GetRecipe(string accessToken, RegionEnum region, Artisan artisanSlug, string recipeSlug, string locale = "en_US") {
			return await GetRecipe(accessToken, region.ToString(), artisanSlug.ToString(), recipeSlug, locale);
		}

		/// <summary>
		/// Returns a single follower by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="followerSlug">The slug of the follower to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Follower> GetFollower(string accessToken, string region, string followerSlug, string locale = "en_US") {
			return await this.Get<Diablo3Follower>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/follower/{1}?locale={2}&access_token={3}",
					region, followerSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single follower by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="followerSlug">The slug of the follower to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Follower> GetFollower(string accessToken, RegionEnum region, Follower followerSlug, string locale = "en_US") {
			return await GetFollower(accessToken, region.ToString(), followerSlug.ToString(), locale);
		}
	}
}
