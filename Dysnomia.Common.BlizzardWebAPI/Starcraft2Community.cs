using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/starcraft-2/community-apis
	/// </summary>
	public class Starcraft2Community : BlizzardWebAPIQuerier, IStarcraft2Community {
		public Starcraft2Community(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

		/// <summary>
		/// Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2StaticProfile> GetStaticProfile(string accessToken, string region, int regionId, string locale = "en_US") {
			return await this.GetAsync<Starcraft2StaticProfile>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/static/profile/{1}?locale={2}&access_token={3}",
					region, regionId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2StaticProfile> GetStaticProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, string locale = "en_US") {
			return await GetStaticProfile(accessToken, region.ToString(), (int)regionId, locale);
		}

		/// <summary>
		/// Returns metadata for an individual's profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2MetadataProfile> GetMetadataProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.GetAsync<Starcraft2MetadataProfile>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/metadata/profile/{1}/{2}/{3}?locale={4}&access_token={5}",
					region, regionId, realmId, profileId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns metadata for an individual's profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2MetadataProfile> GetMetadataProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetMetadataProfile(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}

		/// <summary>
		/// Returns data about an individual Starcraft2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2Profile> GetProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.GetAsync<Starcraft2Profile>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/profile/{1}/{2}/{3}?locale={4}&access_token={5}",
					region, regionId, realmId, profileId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns data about an individual Starcraft2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2Profile> GetProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetProfile(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}

		/// <summary>
		/// Returns a ladder summary for an individual Starcraft2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2ProfileLadderSummary> GetProfileLadderSummary(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.GetAsync<Starcraft2ProfileLadderSummary>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/profile/{1}/{2}/{3}/ladder/summary?locale={4}&access_token={5}",
					region, regionId, realmId, profileId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a ladder summary for an individual Starcraft2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2ProfileLadderSummary> GetProfileLadderSummary(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetProfileLadderSummary(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}

		/// <summary>
		/// Returns data about an individual profile's ladder.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="ladderId">The ID of the ladder for which to retrieve data.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2ProfileLadder> GetProfileLadder(string accessToken, string region, int regionId, int realmId, ulong profileId, int ladderId, string locale = "en_US") {
			return await this.GetAsync<Starcraft2ProfileLadder>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/profile/{1}/{2}/{3}/ladder/{4}?locale={5}&access_token={6}",
					region, regionId, realmId, profileId, ladderId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns data about an individual profile's ladder.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="ladderId">The ID of the ladder for which to retrieve data.</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<Starcraft2ProfileLadder> GetProfileLadder(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, int ladderId, string locale = "en_US") {
			return await GetProfileLadder(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, ladderId, locale);
		}

		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		public async Task<Starcraft2GrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, string region, int regionId) {
			return await this.GetAsync<Starcraft2GrandmasterLeaderboard>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/ladder/grandmaster/{1}?access_token={2}",
					region, regionId, accessToken
				)
			);
		}
		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		public async Task<Starcraft2GrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId) {
			return await GetGrandmasterLeaderboard(accessToken, region.ToString(), (int)regionId);
		}

		/// <summary>
		/// Returns data about the current season.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		public async Task<Starcraft2Season> GetLadderSeason(string accessToken, string region, int regionId) {
			return await this.GetAsync<Starcraft2Season>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/ladder/season/{1}?access_token={2}",
					region, regionId, accessToken
				)
			);
		}
		/// <summary>
		/// Returns data about the current season.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		public async Task<Starcraft2Season> GetLadderSeason(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId) {
			return await GetLadderSeason(accessToken, region.ToString(), (int)regionId);
		}

		/// <summary>
		/// Returns metadata for an individual's account.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="accountId">The ID of the account for which to retrieve data.</param>
		/// <returns></returns>
		public async Task<Starcraft2Account> GetPlayerAccount(string accessToken, string region, ulong accountId) {
			// Sometimes, blizzard decides to return a 404 ... for no reason, so we will retry multiple times

			for (int i = 0; i < 5; i++) {
				try {
					return (await this.GetAsync<IEnumerable<Starcraft2Account>>(
						string.Format(
							"https://{0}.api.blizzard.com/sc2/player/{1}?access_token={2}",
							region, accountId, accessToken
						)
					)).FirstOrDefault();
				} catch (JsonException e) {
					// Do nothing with this exception, might be the 404 error, except if we failed multiple time
					if (i == 4) {
						throw;
					}
				}

				Thread.Sleep(i * 150);
			}

			// Should be unreachable, but the compiler don't want to understand
#pragma warning disable S112 // General exceptions should never be thrown
			throw new Exception();
#pragma warning restore S112 // General exceptions should never be thrown
		}
		/// <summary>
		/// Returns metadata for an individual's account.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="accountId">The ID of the account for which to retrieve data.</param>
		/// <returns></returns>
		public async Task<Starcraft2Account> GetPlayerAccount(string accessToken, RegionEnum region, ulong accountId) {
			return await GetPlayerAccount(accessToken, region.ToString(), accountId);
		}
	}
}
