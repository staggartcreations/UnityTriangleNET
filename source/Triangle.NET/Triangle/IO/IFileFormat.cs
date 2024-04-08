// -----------------------------------------------------------------------
// <copyright file="IFileFormat.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace sc.trianglenet.IO
{
    public interface IFileFormat
    {
        bool IsSupported(string file);
    }
}
