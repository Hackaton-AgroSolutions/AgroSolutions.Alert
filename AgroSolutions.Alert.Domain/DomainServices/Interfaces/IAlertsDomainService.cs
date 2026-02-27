using AgroSolutions.Alert.Domain.Events;

namespace AgroSolutions.Alert.Domain.DomainServices.Interfaces;

public interface IAlertsDomainService
{
    Task<byte> CheckAllRulesAsync(ReceivedSensorDataEvent receivedSensorDataEvent);
}
