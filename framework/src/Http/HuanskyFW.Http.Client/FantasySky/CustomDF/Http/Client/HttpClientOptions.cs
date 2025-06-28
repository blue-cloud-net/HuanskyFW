using HuanskyFW.Http.Client.Proxying;

namespace HuanskyFW.Http.Client;

internal class HttpClientOptions
{
    public HttpClientOptions()
    {
        this.HttpClientProxies = new Dictionary<Type, HttpClientProxyConfig>();
    }

    public Dictionary<Type, HttpClientProxyConfig> HttpClientProxies { get; set; }
}
