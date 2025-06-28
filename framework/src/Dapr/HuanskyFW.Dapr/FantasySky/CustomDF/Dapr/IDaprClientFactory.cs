using Dapr.Client;

namespace HuanskyFW.Dapr;

public interface IDaprClientFactory
{
    DaprClient Create(Action<DaprClientBuilder> builderAction = null);

    HttpClient CreateHttpClient(
        string appId = null,
        string daprEndpoint = null,
        string daprApiToken = null
    );
}
