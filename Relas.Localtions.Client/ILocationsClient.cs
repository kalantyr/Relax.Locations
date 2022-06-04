using Relax.Locations.Models;

namespace Relas.Localtions.Client
{
    public interface ILocationsClient
    {
        Task<IReadOnlyCollection<LocationInfo>> GetAllLocationsAsync(string userToken, CancellationToken cancellation);

        Task<IReadOnlyCollection<object>> GetStaticObjectsAsync(uint locationId, string userToken, CancellationToken cancellation);
    }
}
