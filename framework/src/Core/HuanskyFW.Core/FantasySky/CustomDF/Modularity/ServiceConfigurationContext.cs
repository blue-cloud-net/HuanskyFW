using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HuanskyFW.Modularity;

public record ServiceConfigurationContext(IServiceCollection Services, IConfiguration Configuration);
