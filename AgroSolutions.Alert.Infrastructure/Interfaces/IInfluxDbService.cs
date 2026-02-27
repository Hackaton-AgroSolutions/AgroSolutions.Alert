using InfluxDB.Client.Core.Flux.Domain;
using InfluxDB.Client.Writes;

namespace AgroSolutions.Alert.Infrastructure.Interfaces;

public interface IInfluxDbService
{
    Task WritePointDataAsync(PointData pointData);
    Task<IEnumerable<FluxTable>> QueryAsync(string query);
}
