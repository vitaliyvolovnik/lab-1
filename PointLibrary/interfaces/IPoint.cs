


namespace PointLibrary.interfaces;

public interface IPoint
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }

    double GetDistance(IPoint other);
    double GetDistanceToOrigin();
}