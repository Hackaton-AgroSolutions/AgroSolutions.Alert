using RabbitMQ.Client;

namespace AgroSolutions.AzureFunction.Infrastructure.Messaging;

public interface IMessagingConnectionFactory
{
    Task<IChannel> CreateChannelAsync(CancellationToken cancellationToken);
}
