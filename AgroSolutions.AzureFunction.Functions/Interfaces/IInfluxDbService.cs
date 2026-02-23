using InfluxDB.Client;

namespace AgroSolutions.AzureFunction.Functions.Interfaces;

public interface IInfluxDbService
{
    void Write(Action<WriteApi> action);
}
