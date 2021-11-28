using Dysnomia.Common.WebAPIWrapper;

using System.Net.Http;

namespace Dysnomia.Common.BlizzardWebAPI {
	public abstract class BlizzardWebAPIQuerier : WebAPIQuerier {
		public BlizzardWebAPIQuerier(IHttpClientFactory clientFactory) : base(clientFactory) {
		}
	}
}
