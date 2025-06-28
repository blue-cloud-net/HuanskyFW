namespace HuanskyFW.Caching.StackExchangeRedis;

public interface IRedisConnectionMultiplexerFactory
{
    public ConnectionMultiplexer GetConnection(string? connectionString);

    Task<ConnectionMultiplexer> GetConnectionAsync(string? connectionString, CancellationToken cancellationToken = default);
}
