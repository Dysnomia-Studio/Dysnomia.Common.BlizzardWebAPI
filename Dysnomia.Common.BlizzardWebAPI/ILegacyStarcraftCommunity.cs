using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/starcraft-2/community-apis, under "Legacy API"
	/// </summary>
	public interface ILegacyStarcraftCommunity {
		/// <summary>
		/// Retrieves data about an individual SC2 profile.
		/// </summary>
		/// <param name="accessToken">Credential Code Flow access token</param>
		/// <param name="region">StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests.</param>
		/// <param name="regionId">You can retrieve these parameters by issuing a GetPlayerAccount request.</param>
		/// <param name="realmId">You can retrieve these parameters by issuing a GetPlayerAccount request.</param>
		/// <param name="profileId">You can retrieve these parameters by issuing a GetPlayerAccount request.</param>
		/// <returns></returns>
		Task<LegacySC2PlayerProfile> GetPlayerProfile(string accessToken, string region, int regionId, int realmId, ulong profileId);
	}
}
