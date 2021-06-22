using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Models;

namespace Dysnomia.Common.BlizzardWebAPI {
	interface ILegacyStarcraftCommunity {
		Task<LegacySC2PlayerProfile> GetPlayerProfile(string accessToken, string region, int regionId, int realmId, ulong profileId);
	}
}
