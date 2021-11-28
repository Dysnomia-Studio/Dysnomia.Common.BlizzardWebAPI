using Dysnomia.Common.BlizzardWebAPI.Enums;

using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class Diablo3CommunityTest : BaseTestClass {
		protected readonly IDiablo3Community diablo3Community;

		public Diablo3CommunityTest(IHttpClientFactory httpClientFactory, IDiablo3Community diablo3Community) : base(httpClientFactory) {
			this.diablo3Community = diablo3Community;
		}

		[Theory]
		[InlineData(Diablo3ImageType.items, "small", "crafting_assortedparts_01_demonhunter_male")]
		[InlineData(Diablo3ImageType.items, "large", "crafting_assortedparts_01_demonhunter_male")]
		[InlineData(Diablo3ImageType.skills, "21", "templar_heal_110")]
		[InlineData(Diablo3ImageType.skills, "42", "templar_heal_110")]
		[InlineData(Diablo3ImageType.skills, "64", "templar_heal_110")]
		public void GetImage_OK(Diablo3ImageType type, string size, string icon) {
			Assert.True(diablo3Community.GetImage(type, size, icon) != null);
		}

		[Theory]
		[InlineData(Diablo3ImageType.items, "smal", "crafting_assortedparts_01_demonhunter_male")]
		[InlineData(Diablo3ImageType.items, "42", "crafting_assortedparts_01_demonhunter_male")]
		[InlineData(Diablo3ImageType.skills, "small", "templar_heal_110")]
		[InlineData(Diablo3ImageType.skills, "41", "templar_heal_110")]
		public void GetImage_NOK(Diablo3ImageType type, string size, string icon) {
			Assert.Throws<ArgumentException>(() => diablo3Community.GetImage(type, size, icon) != null);
		}

		[Fact]
		public async Task GetActIndex_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetActIndex(token, RegionEnum.EU);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetAct_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetAct(token, RegionEnum.EU, 1);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetArtisan_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetArtisan(token, RegionEnum.EU, Diablo3ArtisanEnum.blacksmith);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetRecipe_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetRecipe(token, RegionEnum.EU, Diablo3ArtisanEnum.blacksmith, "apprentice-flamberge");
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetFollower_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetFollower(token, RegionEnum.EU, Diablo3FollowerEnum.templar);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetCharacterClass_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetCharacterClass(token, RegionEnum.EU, Diablo3ClassEnum.barbarian);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetApiSkill_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetApiSkill(token, RegionEnum.EU, Diablo3ClassEnum.barbarian, Diablo3SkillEnum.bash);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetItemTypeIndex_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetItemTypeIndex(token, RegionEnum.EU);
			Assert.True(res != null);
			Assert.True(res.Any());
		}

		[Fact]
		public async Task GetItemType_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetItemType(token, RegionEnum.EU, "sword2h");
			Assert.True(res != null);
			Assert.True(res.Any());
		}

		[Fact]
		public async Task GetItem_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetItem(token, RegionEnum.EU, "corrupted-ashbringer-Unique_Sword_2H_104_x1");
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetAccount_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetAccount(token, RegionEnum.EU, BattleNetBattleTag);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetHero_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetHero(token, RegionEnum.EU, BattleNetBattleTag, BattleNetHeroId);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetDetailedHeroItems_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetDetailedHeroItems(token, RegionEnum.EU, BattleNetBattleTag, BattleNetHeroId);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetDetailedFollowersItems_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetDetailedFollowersItems(token, RegionEnum.EU, BattleNetBattleTag, BattleNetHeroId);
			Assert.True(res != null);
		}
	}
}
