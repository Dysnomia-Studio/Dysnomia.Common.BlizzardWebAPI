using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class LegacyStarcraft2CommunityTest : BaseTestClass {
		protected readonly ILegacyStarcraft2Community legacyStarcraftCommunity;

		public LegacyStarcraft2CommunityTest() {
			this.legacyStarcraftCommunity = new LegacyStarcraft2Community();
		}

		[Fact]
		public async Task GetPlayerProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await legacyStarcraftCommunity.GetPlayerProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}
	}
}
