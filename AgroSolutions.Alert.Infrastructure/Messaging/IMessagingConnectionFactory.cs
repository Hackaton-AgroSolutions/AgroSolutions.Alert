using RabbitMQ.Client;

namespace AgroSolutions.Alert.Infrastructure.Messaging;

public interface IMessagingConnectionFactory
{
    Task<IChannel> CreateChannelAsync(CancellationToken cancellationToken);
}
