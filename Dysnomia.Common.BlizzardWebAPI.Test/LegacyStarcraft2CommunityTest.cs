using Dysnomia.Common.BlizzardWebAPI.Enums;

using System.Net.Http;
using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class LegacyStarcraft2CommunityTest : BaseTestClass {
		protected readonly ILegacyStarcraft2Community legacyStarcraftCommunity;

		public LegacyStarcraft2CommunityTest(IHttpClientFactory httpClientFactory, ILegacyStarcraft2Community legacyStarcraftCommunity) : base(httpClientFactory) {
			this.legacyStarcraftCommunity = legacyStarcraftCommunity;
		}

		[Fact]
		public async Task GetPlayerProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await legacyStarcraftCommunity.GetPlayerProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}
	}
}
