using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/starcraft-2/community-apis
	/// </summary>
	public interface IStarcraftCommunity {
		/// <summary>
		/// Returns all static SC2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<StarcraftStaticProfile> GetStaticProfile(string accessToken, string region, int regionId, string locale = "en_US");
		/// <summary>
		/// Returns all static SC2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<StarcraftStaticProfile> GetStaticProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, string locale = "en_US");

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
		Task<StarcraftMetadataProfile> GetMetadataProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<StarcraftMetadataProfile> GetMetadataProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<Models.StarcraftProfile> GetProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<Models.StarcraftProfile> GetProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<StarcraftProfileLadderSummary> GetProfileLadderSummary(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<StarcraftProfileLadderSummary> GetProfileLadderSummary(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<StarcraftProfileLadder> GetProfileLadder(string accessToken, string region, int regionId, int realmId, ulong profileId, int ladderId, string locale = "en_US");
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
		Task<StarcraftProfileLadder> GetProfileLadder(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, int ladderId, string locale = "en_US");

		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<StarcraftGrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, string region, int regionId);
		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<StarcraftGrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId);
	}
}
