
using sc.trianglenet.Topology.DCEL;

namespace sc.trianglenet.Voronoi
{

    public interface IVoronoiFactory
    {
        void Initialize(int vertexCount, int edgeCount, int faceCount);

        void Reset();

        Vertex CreateVertex(double x, double y);

        HalfEdge CreateHalfEdge(Vertex origin, Face face);

        Face CreateFace(Geometry.Vertex vertex);
    }
}
