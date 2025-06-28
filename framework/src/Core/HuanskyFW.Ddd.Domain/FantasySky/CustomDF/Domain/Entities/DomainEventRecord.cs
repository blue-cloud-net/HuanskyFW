namespace HuanskyFW.Domain.Entities;

public record DomainEventRecord(object EventData, long EventOrder);
