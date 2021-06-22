using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class StarcraftCommunityTest : BaseTestClass {
		protected readonly IStarcraftCommunity starcraftCommunity;

		public StarcraftCommunityTest() {
			this.starcraftCommunity = new StarcraftCommunity();
		}

		[Fact]
		public async Task GetStaticProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetStaticProfile(token, RegionEnum.EU.ToString(), (int)StarCraft2RegionEnum.Europe);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetMetadataProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetMetadataProfile(token, RegionEnum.EU.ToString(), (int)StarCraft2RegionEnum.Europe, (int)StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}
	}
}
