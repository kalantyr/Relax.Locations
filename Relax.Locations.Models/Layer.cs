namespace Relax.Locations.Models
{
    public class Layer
    {
        /// <summary>
        /// Чем больше значение, тем выше накладывается слой
        /// </summary>
        public uint Order { get; set; }

        public MapObjectLocation[] Objects { get; set; } = Array.Empty<MapObjectLocation>();
    }
}
