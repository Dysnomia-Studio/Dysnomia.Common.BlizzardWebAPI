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

			var res = await starcraftCommunity.GetStaticProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetMetadataProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetMetadataProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetProfile_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetProfile(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetLadderSummary_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetProfileLadderSummary(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetProfileLadder_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetProfileLadder(token, RegionEnum.EU, StarCraft2RegionEnum.Europe, StarCraft2RealmEnum.Europe, BattleNetProfileId, 0);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetGrandmasterLeaderboard_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetGrandmasterLeaderboard(token, RegionEnum.EU, StarCraft2RegionEnum.Europe);

			Assert.True(res != null);
		}

		[Fact]
		public async Task GetLadderSeason_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await starcraftCommunity.GetLadderSeason(token, RegionEnum.EU, StarCraft2RegionEnum.Europe);

			Assert.True(res != null);
		}
	}
}
