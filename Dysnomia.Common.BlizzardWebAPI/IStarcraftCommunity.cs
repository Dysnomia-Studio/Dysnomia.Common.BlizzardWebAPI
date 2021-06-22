using System.Threading.Tasks;

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
	}
}
