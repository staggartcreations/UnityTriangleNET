// -----------------------------------------------------------------------
// <copyright file="ITriangulator.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using sc.trianglenet.Geometry;

namespace sc.trianglenet.Meshing
{

    /// <summary>
    /// Interface for point set triangulation.
    /// </summary>
    public interface ITriangulator
    {
        /// <summary>
        /// Triangulates a point set.
        /// </summary>
        /// <param name="points">Collection of points.</param>
        /// <param name="config"></param>
        /// <returns>Mesh</returns>
        IMesh Triangulate(IList<Vertex> points, Configuration config);
    }
}
