using HuanskyFW.DependencyInjection;

namespace HuanskyFW.DistributedLocking;

[Dependency(typeof(IDistributedLock), ReplaceServices = true)]
public class DaprDistributedLock : IDistributedLock
{
    public Task<IDistributedLockHandle?> TryAcquireAsync(
        string key, TimeSpan? timeout = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
