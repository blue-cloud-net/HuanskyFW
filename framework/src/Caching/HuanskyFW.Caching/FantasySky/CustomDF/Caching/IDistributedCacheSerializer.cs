namespace HuanskyFW.Caching;

public interface IDistributedCacheSerializer
{
    T? Deserialize<T>(byte[] bytes);

    byte[] Serialize<T>(T obj);
}
