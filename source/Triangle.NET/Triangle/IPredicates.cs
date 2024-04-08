﻿// -----------------------------------------------------------------------
// <copyright file="IPredicates.cs">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

using sc.trianglenet.Geometry;

namespace sc.trianglenet
{

    public interface IPredicates
    {
        double CounterClockwise(Point a, Point b, Point c);

        double InCircle(Point a, Point b, Point c, Point p);

        Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta);
    
        Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta,
            double offconstant);
    }
}
