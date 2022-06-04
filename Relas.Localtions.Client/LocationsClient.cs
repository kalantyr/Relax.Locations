using Relax.Locations.Models;

namespace Relas.Localtions.Client
{
    public class LocationsClient: ILocationsClient, IMapObjectsClient
    {
        public Task<IReadOnlyCollection<LocationInfo>> GetAllLocationsAsync(string userToken, CancellationToken cancellation)
        {
            IReadOnlyCollection<LocationInfo> result = new []
            {
                new LocationInfo
                {
                    Id = 1,
                    Name = "Эдем",
                    Version = new Version(0, 1)
                },
                new LocationInfo
                {
                    Id = 2,
                    Name = "Подземелье",
                    Version = new Version(0, 1)
                },
            };
            return Task.FromResult(result);
        }

        public Task<IReadOnlyCollection<Layer>> GetLayersAsync(uint locationId, string userToken, CancellationToken cancellation)
        {
            IReadOnlyCollection<Layer> layers = new []
            {
                new Layer
                {
                    Order = 5,
                    Objects = new []
                    {
                        new MapObjectLocation { TypeId = 12, CenterX = -5, CenterY = -4.5f },
                        new MapObjectLocation { TypeId = 12, CenterX = 10, CenterY = 8.5f },
                    }
                },
                new Layer
                {
                    Order = 2,
                    Objects = new []
                    {
                        new MapObjectLocation { TypeId = 123, CenterX = -2, CenterY = -3.5f },
                        new MapObjectLocation { TypeId = 1234, CenterX = 9, CenterY = 7 },
                    }
                }
            };
            return Task.FromResult(layers);
        }

        public Task<IReadOnlyCollection<MapObject>> GetMapObjectsAsync(uint locationId, string userToken, CancellationToken cancellation)
        {
            IReadOnlyCollection<MapObject> mapObjects = new[]
            {
                new MapObject // Block
                {
                    Id = 12,
                    Width = 1,
                    Height = 1
                },
                new MapObject // Tree
                {
                    Id = 123,
                    Width = 2,
                    Height = 2
                },
                new MapObject // Stone
                {
                    Id = 1234,
                    Width = 1,
                    Height = 1
                }
            };
            return Task.FromResult(mapObjects);
        }
    }
}
