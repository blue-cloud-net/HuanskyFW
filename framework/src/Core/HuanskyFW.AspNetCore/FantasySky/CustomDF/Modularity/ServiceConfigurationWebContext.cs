using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HuanskyFW.Modularity;

public record ServiceConfigurationWebContext(IServiceCollection Services, IConfiguration Configuration, IHostBuilder Host) : ServiceConfigurationContext(Services, Configuration);
