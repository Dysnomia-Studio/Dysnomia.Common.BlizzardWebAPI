using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class LegacyStarcraftCommunityTest : BaseTestClass {
		protected readonly ILegacyStarcraftCommunity legacyStarcraftCommunity;

		public LegacyStarcraftCommunityTest() {
			this.legacyStarcraftCommunity = new LegacyStarcraftCommunity();
		}

		[Fact]
		public async Task GetPlayerProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await legacyStarcraftCommunity.GetPlayerProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}
	}
}
