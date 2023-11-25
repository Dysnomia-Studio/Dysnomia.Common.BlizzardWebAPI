using Dysnomia.Common.BlizzardWebAPI.Models;
using Dysnomia.Common.WebAPIWrapper;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/guides/using-oauth
	/// </summary>
	public class TokenQuerier : WebAPIQuerier {
		private readonly string clientId;
		private readonly string clientSecret;
		private readonly string redirectURI;
		private readonly string region;

		public TokenQuerier(IHttpClientFactory httpClientFactory, string clientId, string clientSecret, string redirectURI, string region) : base(httpClientFactory) {
			this.clientId = clientId;
			this.clientSecret = clientSecret;
			this.redirectURI = redirectURI;
			this.region = region;
		}

		/// <summary>
		/// The OAuth client credentials flow is used to exchange a pair of client credentials (client_id and client_secret) for an access token.
		/// https://develop.battle.net/documentation/guides/using-oauth/client-credentials-flow
		/// </summary>
		/// <returns>Access token response</returns>
		public async Task<AccessTokenResponse> GetClientCredentialFlow() {
			var headers = new Dictionary<string, string>();
			headers.Add("Authorization", (new AuthenticationHeaderValue("Basic",
				Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", clientId, clientSecret)))
			)).ToString());

			using var content = new MultipartFormDataContent {
				{ new StringContent("client_credentials"), "grant_type" }
			};

			return await this.PostAsync<AccessTokenResponse>(
				string.Format("https://{0}.battle.net/oauth/token", this.region),
				content,
				headers
			);
		}

		/// <summary>
		/// The OAuth 2.0 Authorization Code Flow allows an application to access a user's data on their behalf. This allows an application to acquire more sensitive, opt-in information about a user, such as their list of World of Warcraft characters, after obtaining the user's permission to do so. The Authorization Code Flow has two major parts: the authorization code request and the access token request.
		/// https://develop.battle.net/documentation/guides/using-oauth/authorization-code-flow
		/// </summary>
		/// <param name="authorization_code">The previously-retrieved authorization_code.</param>
		/// <param name="scope">The scopes needed for the access token. Note that this can be fewer scopes than the authorization.</param>
		/// <returns>Access token response</returns>
		public async Task<AccessTokenResponse> GetAuthorizationCodeFlow(string authorization_code, string scope = "wow.profile,Starcraft2.profile,d3.profile,openid") {
			var headers = new Dictionary<string, string>();
			headers.Add("Authorization", (new AuthenticationHeaderValue("Basic",
				Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", clientId, clientSecret)))
			)).ToString());

			using var content = new MultipartFormDataContent {
				{ new StringContent(redirectURI), "redirect_uri" },
				{ new StringContent(scope), "scope" },
				{ new StringContent(authorization_code), "code" },
				{ new StringContent("authorization_code"), "grant_type" }
			};

			return await this.PostAsync<AccessTokenResponse>(
				string.Format("https://{0}.battle.net/oauth/token", this.region),
				content,
				headers
			);
		}
	}
}
