using Microsoft.Extensions.Caching.Distributed;

namespace HuanskyFW.Caching;

public class DistributedCacheOptions
{
    public static string Path = "DistributedCache";

    public DistributedCacheOptions()
    {
        this.KeyPrefix = String.Empty;
        this.GlobalCacheEntryOptions = new DistributedCacheEntryOptions();
    }

    /// <summary>
    /// Cache key prefix.
    /// </summary>
    public string KeyPrefix { get; set; }

    /// <summary>
    /// Global Cache entry options.
    /// </summary>
    public DistributedCacheEntryOptions GlobalCacheEntryOptions { get; set; }
}
