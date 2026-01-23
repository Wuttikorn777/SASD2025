using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.DataClump2;

// 4.2
public class DataClump2
{
    public po AddPoint(Point a, Point b)
    {
        return (a.x + b.x), a.Y + b.y);
    }
}

public class Point
{
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

}
