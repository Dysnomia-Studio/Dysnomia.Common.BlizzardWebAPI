using Microsoft.Extensions.DependencyInjection;

namespace Dysnomia.Common.BlizzardWebAPI.Test {
	public class Startup {
		public Startup() {
		}


		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddTransient<IDiablo3Community, Diablo3Community>();
			services.AddTransient<ILegacyStarcraft2Community, LegacyStarcraft2Community>();
			services.AddTransient<IStarcraft2Community, Starcraft2Community>();

			services.AddHttpClient();
		}
	}
}
