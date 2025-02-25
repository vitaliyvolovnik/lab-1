
namespace PointLibraryTest;

using PointLibrary;

using Xunit;
using System;

public class PointTests
{
    [Fact]
    public void GetDistance_SamePoints_ReturnsZero()
    {
        // Arrange
        Point p1 = new(1, 1, 1);
        Point p2 = new(1, 1, 1);

        // Act
        double distance = p1.GetDistance(p2);

        // Assert
        Assert.Equal(0, distance);
    }

    [Fact]
    public void GetDistance_DifferentXAndYCoordinates_ReturnsCorrectValue()
    {
        // Arrange
        Point p1 = new(0, 0, 0);
        Point p2 = new(3, 4, 0);

        // Act
        double distance = p1.GetDistance(p2);

        // Assert
        Assert.Equal(5, distance);
    }

    [Fact]
    public void GetDistanceToOrigin_PointAtOneOneOne_ReturnsSqrt3()
    {
        // Arrange
        Point p1 = new(1, 1, 1);

        // Act
        double distance = p1.GetDistanceToOrigin();

        // Assert
        Assert.Equal(Math.Sqrt(3), distance, precision: 10);
    }

    [Fact]
    public void GetDistanceToOrigin_PointAtZero_ReturnsZero()
    {
        // Arrange
        Point p1 = new(0, 0, 0);

        // Act
        double distance = p1.GetDistanceToOrigin();

        // Assert
        Assert.Equal(0, distance);
    }
}