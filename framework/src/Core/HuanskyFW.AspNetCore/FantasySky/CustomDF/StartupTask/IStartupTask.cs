namespace HuanskyFW.StartupTask;

public interface IStartupTask
{
    int Order { get; }

    Task ExecuteAsync(CancellationToken cancellationToken = default);
}
