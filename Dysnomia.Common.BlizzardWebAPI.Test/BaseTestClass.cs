using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Models;

using Microsoft.Extensions.Configuration;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public abstract class BaseTestClass {
		protected string CLIENT_ID = "";
		protected string CLIENT_SECRET = "";
		protected ulong BattleNetAccountId = 0;
		protected ulong BattleNetProfileId = 0;
		protected const ulong INVALID_BNETID = 0;
		protected string REDIRECT_URI = "";

		protected Task<AccessTokenResponse> authCodeFlowToken;
		protected Task<AccessTokenResponse> clientCredentialFlowToken;

		public BaseTestClass() {
			var config = new ConfigurationBuilder()
				.AddUserSecrets<BaseTestClass>()
				.AddJsonFile("appsettings.json")
				.Build();

			CLIENT_ID = config["CLIENT_ID"];
			CLIENT_SECRET = config["CLIENT_SECRET"];
			BattleNetAccountId = ulong.Parse(config["BattleNetAccountId"]);
			BattleNetProfileId = ulong.Parse(config["BattleNetProfileId"]);
			REDIRECT_URI = config["REDIRECT_URI"];

			var tokenQuerier = new TokenQuerier(CLIENT_ID, CLIENT_SECRET, REDIRECT_URI, "eu");
			authCodeFlowToken = tokenQuerier.GetAuthorizationCodeFlow("TODO");
			clientCredentialFlowToken = tokenQuerier.GetClientCredentialFlow();
		}
	}
}
