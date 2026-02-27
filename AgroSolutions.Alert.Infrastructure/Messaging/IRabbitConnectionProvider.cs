using RabbitMQ.Client;

namespace AgroSolutions.Alert.Infrastructure.Messaging;

public interface IRabbitConnectionProvider
{
    Task<IConnection> GetConnectionAsync(CancellationToken cancellationToken);
}
