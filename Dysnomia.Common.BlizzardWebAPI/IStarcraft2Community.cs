using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;
using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/starcraft-2/community-apis
	/// </summary>
	public interface IStarcraft2Community {
		/// <summary>
		/// Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Starcraft2StaticProfile> GetStaticProfile(string accessToken, string region, int regionId, string locale = "en_US");
		/// <summary>
		/// Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <param name="locale">The locale to reflect in localized data.</param>
		/// <returns></returns>
		Task<Starcraft2StaticProfile> GetStaticProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, string locale = "en_US");

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
		Task<Starcraft2MetadataProfile> GetMetadataProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<Starcraft2MetadataProfile> GetMetadataProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<Models.Starcraft2Profile> GetProfile(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<Models.Starcraft2Profile> GetProfile(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<Starcraft2ProfileLadderSummary> GetProfileLadderSummary(string accessToken, string region, int regionId, int realmId, ulong profileId, string locale = "en_US");
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
		Task<Starcraft2ProfileLadderSummary> GetProfileLadderSummary(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, string locale = "en_US");

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
		Task<Starcraft2ProfileLadder> GetProfileLadder(string accessToken, string region, int regionId, int realmId, ulong profileId, int ladderId, string locale = "en_US");
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
		Task<Starcraft2ProfileLadder> GetProfileLadder(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId, StarCraft2RealmEnum realmId, ulong profileId, int ladderId, string locale = "en_US");

		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<Starcraft2GrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, string region, int regionId);
		/// <summary>
		/// Returns ladder data for the current season's grandmaster leaderboard.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<Starcraft2GrandmasterLeaderboard> GetGrandmasterLeaderboard(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId);

		/// <summary>
		/// Returns data about the current season.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<Starcraft2Season> GetLadderSeason(string accessToken, string region, int regionId);
		/// <summary>
		/// Returns data about the current season.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="regionId">The region for the profile</param>
		/// <returns></returns>
		Task<Starcraft2Season> GetLadderSeason(string accessToken, RegionEnum region, StarCraft2RegionEnum regionId);

		/// <summary>
		/// Returns metadata for an individual's account.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="accountId">The ID of the account for which to retrieve data.</param>
		/// <returns></returns>
		Task<Starcraft2Account> GetPlayerAccount(string accessToken, string region, ulong accountId);
		/// <summary>
		/// Returns metadata for an individual's account.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="accountId">The ID of the account for which to retrieve data.</param>
		/// <returns></returns>
		Task<Starcraft2Account> GetPlayerAccount(string accessToken, RegionEnum region, ulong accountId);
	}
}
