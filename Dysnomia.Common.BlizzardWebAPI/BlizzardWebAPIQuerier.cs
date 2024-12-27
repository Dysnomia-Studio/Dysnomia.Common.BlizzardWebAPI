using Dysnomia.Common.WebAPIWrapper;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.BlizzardWebAPI {
    public abstract class BlizzardWebAPIQuerier : WebAPIQuerier {
        public BlizzardWebAPIQuerier(IHttpClientFactory clientFactory) : base(clientFactory) {
        }

        protected Task<T> GetUsingTokenAsync<T>(string url, string accessToken, Dictionary<string, string> headers = null) {
            headers ??= [];
            headers.Add("Authorization", $"Bearer {accessToken}");

            return GetAsync<T>(url, headers);
        }

    }
}
