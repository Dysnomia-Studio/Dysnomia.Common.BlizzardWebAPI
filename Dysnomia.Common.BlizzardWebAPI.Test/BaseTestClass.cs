using Dysnomia.Common.BlizzardWebAPI.Models;

using Microsoft.Extensions.Configuration;

using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public abstract class BaseTestClass {
		protected string CLIENT_ID = "";
		protected string CLIENT_SECRET = "";
		protected ulong BattleNetAccountId = 0;
		protected ulong BattleNetProfileId = 0;
		protected string BattleNetBattleTag = "";
		protected ulong BattleNetHeroId = 0;
		protected const ulong INVALID_BNETID = 0;
		protected string REDIRECT_URI = "";

		protected Task<AccessTokenResponse> authCodeFlowToken;
		protected Task<AccessTokenResponse> clientCredentialFlowToken;

		public BaseTestClass(IHttpClientFactory httpClientFactory) {
			var config = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.AddUserSecrets<BaseTestClass>(optional: true)
				.AddJsonFile("appsettings.json")
				.Build();

			CLIENT_ID = config["CLIENT_ID"];
			CLIENT_SECRET = config["CLIENT_SECRET"];
			BattleNetAccountId = ulong.Parse(config["BattleNetAccountId"]);
			BattleNetProfileId = ulong.Parse(config["BattleNetProfileId"]);
			BattleNetBattleTag = config["BattleNetBattleTag"];
			BattleNetHeroId = ulong.Parse(config["BattleNetHeroId"]);
			REDIRECT_URI = config["REDIRECT_URI"];

			var tokenQuerier = new TokenQuerier(httpClientFactory, CLIENT_ID, CLIENT_SECRET, REDIRECT_URI, "eu");
			authCodeFlowToken = tokenQuerier.GetAuthorizationCodeFlow("TODO");
			clientCredentialFlowToken = tokenQuerier.GetClientCredentialFlow();
		}
	}
}
