using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class LegacyStarcraftCommunityTest : BaseTestClass {
		protected readonly LegacyStarcraftCommunity legacyStarcraftCommunity;

		public LegacyStarcraftCommunityTest() {
			this.legacyStarcraftCommunity = new LegacyStarcraftCommunity();
		}

		[Fact]
		public async Task GetPlayerProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await legacyStarcraftCommunity.GetPlayerProfile(token, RegionEnum.EU.ToString(), (int)StarCraft2RegionEnum.Europe, (int)StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}
	}
}
