﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

using Dysnomia.Common.BlizzardWebAPI.Models;
using Dysnomia.Common.WebAPIWrapper;

namespace Dysnomia.Common.BlizzardWebAPI {
	/// <summary>
	/// See https://develop.battle.net/documentation/guides/using-oauth
	/// </summary>
	public class TokenQuerier : WebAPIQuerier {
		private readonly string clientId;
		private readonly string clientSecret;
		private readonly string redirectURI;
		private readonly string region;

		public TokenQuerier(string clientId, string clientSecret, string redirectURI, string region) {
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
			using var client = new HttpClient();
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
				Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", clientId, clientSecret)))
			);

			using var content = new MultipartFormDataContent();
			content.Add(new StringContent("client_credentials"), "grant_type");

			var res = await client.PostAsync(
				string.Format("https://{0}.battle.net/oauth/token", this.region),
				content
			);

			return JsonSerializer.Deserialize<AccessTokenResponse>(await res.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// The OAuth 2.0 Authorization Code Flow allows an application to access a user's data on their behalf. This allows an application to acquire more sensitive, opt-in information about a user, such as their list of World of Warcraft characters, after obtaining the user's permission to do so. The Authorization Code Flow has two major parts: the authorization code request and the access token request.
		/// https://develop.battle.net/documentation/guides/using-oauth/authorization-code-flow
		/// </summary>
		/// <param name="authorization_code">The previously-retrieved authorization_code.</param>
		/// <param name="scope">The scopes needed for the access token. Note that this can be fewer scopes than the authorization.</param>
		/// <returns>Access token response</returns>
		public async Task<AccessTokenResponse> GetAuthorizationCodeFlow(string authorization_code, string scope = "wow.profile,Starcraft2.profile,d3.profile,openid") {
			using var client = new HttpClient();
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
				Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", clientId, clientSecret)))
			);

			using var content = new MultipartFormDataContent();
			content.Add(new StringContent(redirectURI), "redirect_uri");
			content.Add(new StringContent(scope), "scope");
			content.Add(new StringContent(authorization_code), "code");
			content.Add(new StringContent("authorization_code"), "grant_type");

			var res = await client.PostAsync(
				string.Format("https://{0}.battle.net/oauth/token", this.region),
				content
			);

			return JsonSerializer.Deserialize<AccessTokenResponse>(await res.Content.ReadAsStringAsync());
		}
	}
}
