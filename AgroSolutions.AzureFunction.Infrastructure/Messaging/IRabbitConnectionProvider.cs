using RabbitMQ.Client;

namespace AgroSolutions.AzureFunction.Infrastructure.Messaging;

public interface IRabbitConnectionProvider
{
    Task<IConnection> GetConnectionAsync(CancellationToken cancellationToken);
}
