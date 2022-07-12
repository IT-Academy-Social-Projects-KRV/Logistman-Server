using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace Core.Constants
{
    public static class NtsGemetryFactories
    {
        /// <summary>
        /// Supplies a set of utility methods for building Geometry objects from lists of Coordinates with SRID WGS84 which using in GPS.
        /// </summary>
        public static GeometryFactory geometryFactoryWGS84 = NtsGeometryServices.Instance.CreateGeometryFactory(GeodeticSystem.WGS84);
    }
}
