// -----------------------------------------------------------------------
// <copyright file="IVoronoi.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using sc.trianglenet.Geometry;

namespace sc.trianglenet.Voronoi.Legacy
{

    /// <summary>
    /// Voronoi diagram interface.
    /// </summary>
    public interface IVoronoi
    {
        /// <summary>
        /// Gets the list of Voronoi vertices.
        /// </summary>
        Point[] Points { get; }

        /// <summary>
        /// Gets the list of Voronoi regions.
        /// </summary>
        ICollection<VoronoiRegion> Regions { get; }

        /// <summary>
        /// Gets the list of edges.
        /// </summary>
        IEnumerable<IEdge> Edges { get; }
    }
}
