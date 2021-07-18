using System;
using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Enums;

using Xunit;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class Diablo3CommunityTest : BaseTestClass {
		protected readonly IDiablo3Community diablo3Community;

		public Diablo3CommunityTest() {
			this.diablo3Community = new Diablo3Community();
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

			var res = await diablo3Community.GetArtisan(token, RegionEnum.EU, Artisan.blacksmith);
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetRecipe_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetRecipe(token, RegionEnum.EU, Artisan.blacksmith, "apprentice-flamberge");
			Assert.True(res != null);
		}

		[Fact]
		public async Task GetFollower_OK() {
			var token = (await this.clientCredentialFlowToken).access_token;

			var res = await diablo3Community.GetFollower(token, RegionEnum.EU, Follower.templar);
			Assert.True(res != null);
		}
	}
}
