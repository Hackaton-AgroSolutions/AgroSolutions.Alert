using AgroSolutions.Alert.Infrastructure.Interfaces;
using InfluxDB.Client;
using InfluxDB.Client.Core.Flux.Domain;
using InfluxDB.Client.Writes;
using Microsoft.Extensions.Configuration;

namespace AgroSolutions.Alert.Infrastructure.Services;

public class InfluxDbService(IConfiguration configuration) : IInfluxDbService
{
    private InfluxDBClient GetClient() => new(new InfluxDBClientOptions(configuration["InfluxDB:Url"])
    {
        Bucket = configuration["InfluxDB:Bucket"],
        Org = configuration["InfluxDB:Org"],
        Username = configuration["InfluxDB:Username"],
        Password = configuration["InfluxDB:Password"],
        Token = configuration["InfluxDB:Token"]
    });

    public async Task WritePointDataAsync(PointData pointData)
    {
        using InfluxDBClient client = GetClient();
        WriteApiAsync writeApiAsync = client.GetWriteApiAsync();
        await writeApiAsync.WritePointAsync(pointData);
    }

    public async Task<IEnumerable<FluxTable>> QueryAsync(string query)
    {
        using InfluxDBClient client = GetClient();
        var queryApi = client.GetQueryApi();
        return await queryApi.QueryAsync(query);
    }
}
