using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;
using Dysnomia.Common.WebAPIWrapper;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// Diablo III community APIs provide endpoints for Diablo III player profiles.
	/// https://develop.battle.net/documentation/diablo-3/community-apis
	/// </summary>
	public class Diablo3Community : WebAPIQuerier, IDiablo3Community {
		public Diablo3Community(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

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
			return await this.GetAsync<Diablo3ActIndex>(
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
			return await this.GetAsync<Diablo3Act>(
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
			return await this.GetAsync<Diablo3Artisan>(
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
		public async Task<Diablo3Artisan> GetArtisan(string accessToken, RegionEnum region, Diablo3ArtisanEnum artisanSlug, string locale = "en_US") {
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
			return await this.GetAsync<Diablo3ArtisanTrainingTierRecipe>(
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
		public async Task<Diablo3ArtisanTrainingTierRecipe> GetRecipe(string accessToken, RegionEnum region, Diablo3ArtisanEnum artisanSlug, string recipeSlug, string locale = "en_US") {
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
			return await this.GetAsync<Diablo3Follower>(
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
		public async Task<Diablo3Follower> GetFollower(string accessToken, RegionEnum region, Diablo3FollowerEnum followerSlug, string locale = "en_US") {
			return await GetFollower(accessToken, region.ToString(), followerSlug.ToString(), locale);
		}

		/// <summary>
		/// Returns a single character class by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="classSlug">The slug of the character class to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3CharacterClass> GetCharacterClass(string accessToken, string region, string classSlug, string locale = "en_US") {
			return await this.GetAsync<Diablo3CharacterClass>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/hero/{1}?locale={2}&access_token={3}",
					region, classSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single character class by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="classSlug">The slug of the character class to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3CharacterClass> GetCharacterClass(string accessToken, RegionEnum region, Diablo3ClassEnum classSlug, string locale = "en_US") {
			return await GetCharacterClass(accessToken, region.ToString(), classSlug.ToString(), locale);
		}

		/// <summary>
		/// Returns a single skill by slug for a specific character class.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="classSlug">The slug of the character class to retrieve.</param>
		/// <param name="skillSlug">The slug of the skill to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Skill> GetApiSkill(string accessToken, string region, string classSlug, string skillSlug, string locale = "en_US") {
			return await this.GetAsync<Diablo3Skill>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/hero/{1}/skill/{2}?locale={3}&access_token={4}",
					region, classSlug, skillSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single skill by slug for a specific character class.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="classSlug">The slug of the character class to retrieve.</param>
		/// <param name="skillSlug">The slug of the skill to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Skill> GetApiSkill(string accessToken, RegionEnum region, Diablo3ClassEnum classSlug, Diablo3SkillEnum skillSlug, string locale = "en_US") {
			return await GetApiSkill(accessToken, region.ToString(), classSlug.ToString(), skillSlug.ToString(), locale);
		}

		/// <summary>
		/// Returns an index of item types.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<IEnumerable<Diablo3ItemTypeIndex>> GetItemTypeIndex(string accessToken, string region, string locale = "en_US") {
			return await this.GetAsync<IEnumerable<Diablo3ItemTypeIndex>>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/item-type?locale={1}&access_token={2}",
					region, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns an index of item types.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<IEnumerable<Diablo3ItemTypeIndex>> GetItemTypeIndex(string accessToken, RegionEnum region, string locale = "en_US") {
			return await GetItemTypeIndex(accessToken, region.ToString(), locale);
		}

		/// <summary>
		/// Returns a single item type by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="itemTypeSlug">The slug of the item type to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<IEnumerable<Diablo3ItemType>> GetItemType(string accessToken, string region, string itemTypeSlug, string locale = "en_US") {
			return await this.GetAsync<IEnumerable<Diablo3ItemType>>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/item-type/{1}?locale={2}&access_token={3}",
					region, itemTypeSlug, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single item type by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="itemTypeSlug">The slug of the item type to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<IEnumerable<Diablo3ItemType>> GetItemType(string accessToken, RegionEnum region, string itemTypeSlug, string locale = "en_US") {
			return await GetItemType(accessToken, region.ToString(), itemTypeSlug, locale);
		}

		/// <summary>
		/// Returns a single item type by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="itemSlugAndId">The slug of the item type to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Item> GetItem(string accessToken, string region, string itemSlugAndId, string locale = "en_US") {
			return await this.GetAsync<Diablo3Item>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/data/item/{1}?locale={2}&access_token={3}",
					region, itemSlugAndId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single item type by slug.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="itemSlugAndId">The slug of the item type to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Item> GetItem(string accessToken, RegionEnum region, string itemSlugAndId, string locale = "en_US") {
			return await GetItem(accessToken, region.ToString(), itemSlugAndId, locale);
		}

		/// <summary>
		/// Returns the specified account profile.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Account> GetAccount(string accessToken, string region, string account, string locale = "en_US") {
			return await this.GetAsync<Diablo3Account>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/profile/{1}/?locale={2}&access_token={3}",
					region, account.Replace("#", "%23"), locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns the specified account profile.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Account> GetAccount(string accessToken, RegionEnum region, string account, string locale = "en_US") {
			return await GetAccount(accessToken, region.ToString(), account, locale);
		}

		/// <summary>
		/// Returns a single hero.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Hero> GetHero(string accessToken, string region, string account, ulong heroId, string locale = "en_US") {
			return await this.GetAsync<Diablo3Hero>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/profile/{1}/hero/{2}?locale={3}&access_token={4}",
					region, account.Replace("#", "%23"), heroId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a single hero.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3Hero> GetHero(string accessToken, RegionEnum region, string account, ulong heroId, string locale = "en_US") {
			return await GetHero(accessToken, region.ToString(), account, heroId, locale);
		}

		/// <summary>
		/// Returns a list of items for the specified hero.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3HeroDetailedItems> GetDetailedHeroItems(string accessToken, string region, string account, ulong heroId, string locale = "en_US") {
			return await this.GetAsync<Diablo3HeroDetailedItems>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/profile/{1}/hero/{2}/items?locale={3}&access_token={4}",
					region, account.Replace("#", "%23"), heroId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a list of items for the specified hero.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3HeroDetailedItems> GetDetailedHeroItems(string accessToken, RegionEnum region, string account, ulong heroId, string locale = "en_US") {
			return await GetDetailedHeroItems(accessToken, region.ToString(), account, heroId, locale);
		}

		/// <summary>
		/// Returns a list of items for the specified hero's followers.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3DetailedFollowersItems> GetDetailedFollowersItems(string accessToken, string region, string account, ulong heroId, string locale = "en_US") {
			return await this.GetAsync<Diablo3DetailedFollowersItems>(
				string.Format(
					"https://{0}.api.blizzard.com/d3/profile/{1}/hero/{2}/follower-items?locale={3}&access_token={4}",
					region, account.Replace("#", "%23"), heroId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a list of items for the specified hero's followers.
		/// </summary>
		/// <param name="accessToken">Client credential flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="account">The BattleTag for the account to retrieve.</param>
		/// <param name="heroId">The ID of the hero to retrieve.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Diablo3DetailedFollowersItems> GetDetailedFollowersItems(string accessToken, RegionEnum region, string account, ulong heroId, string locale = "en_US") {
			return await GetDetailedFollowersItems(accessToken, region.ToString(), account, heroId, locale);
		}
	}
}
