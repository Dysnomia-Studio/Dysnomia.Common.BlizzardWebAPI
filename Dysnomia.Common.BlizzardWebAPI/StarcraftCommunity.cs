﻿using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/starcraft-2/community-apis
	/// </summary>
	public class StarcraftCommunity : BlizzardWebAPIQuerier, IStarcraftCommunity {
		/// <summary>
		/// Returns all static SC2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftStaticProfile> GetStaticProfile(string accessToken, string region, int regionId, string locale = "en_US") {
			return await this.Get<StarcraftStaticProfile>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/static/profile/{1}?locale={2}&access_token={3}",
					region, regionId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns all static SC2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftStaticProfile> GetStaticProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, string locale = "en_US") {
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
		public async Task<StarcraftMetadataProfile> GetMetadataProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.Get<StarcraftMetadataProfile>(
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
		public async Task<StarcraftMetadataProfile> GetMetadataProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetMetadataProfile(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}

		/// <summary>
		/// Returns data about an individual SC2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftProfile> GetProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.Get<StarcraftProfile>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/profile/{1}/{2}/{3}?locale={4}&access_token={5}",
					region, regionId, realmId, profileId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns data about an individual SC2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftProfile> GetProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetProfile(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}

		/// <summary>
		/// Returns a ladder summary for an individual SC2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftLadderSummary> GetLadderSummary(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US") {
			return await this.Get<StarcraftLadderSummary>(
				string.Format(
					"https://{0}.api.blizzard.com/sc2/profile/{1}/{2}/{3}/ladder/summary?locale={4}&access_token={5}",
					region, regionId, realmId, profileId, locale, accessToken
				)
			);
		}
		/// <summary>
		/// Returns a ladder summary for an individual SC2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="realmId">Realm Id (1/2)</param>
		/// <param name="profileId">The profile ID</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		public async Task<StarcraftLadderSummary> GetLadderSummary(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US") {
			return await GetLadderSummary(accessToken, region.ToString(), (int)regionId, (int)realmId, profileId, locale);
		}
	}
}