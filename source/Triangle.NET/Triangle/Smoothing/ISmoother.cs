// -----------------------------------------------------------------------
// <copyright file="ISmoother.cs">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

using sc.trianglenet.Meshing;

namespace sc.trianglenet.Smoothing
{

    /// <summary>
    /// Interface for mesh smoothers.
    /// </summary>
    public interface ISmoother
    {
        void Smooth(IMesh mesh);
        void Smooth(IMesh mesh, int limit);
    }
}