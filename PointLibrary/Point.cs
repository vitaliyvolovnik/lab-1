using PointLibrary.interfaces;

namespace PointLibrary;

public class Point: IPoint
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Point(double x, double y) : this(x, y, 0) { }
    public Point() : this(0, 0, 0) { }

    public double GetDistance(IPoint other)
    {
        double xDiff = X - other.X;
        double yDiff = Y - other.Y;
        double zDiff = Z - other.Z;
        return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
    }

    public double GetDistanceToOrigin()
    {
        return GetDistance(new Point());
    }
}
