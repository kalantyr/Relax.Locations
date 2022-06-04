using Relax.Locations.Models;

namespace Relas.Localtions.Client
{
    public interface IMapObjectsClient
    {
        Task<IReadOnlyCollection<MapObject>> GetMapObjectsAsync(uint locationId, string userToken, CancellationToken cancellation);
    }
}
