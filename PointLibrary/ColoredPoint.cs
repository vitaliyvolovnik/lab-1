using SixLabors.ImageSharp.PixelFormats;

namespace PointLibrary;


public class ColoredPoint : Point
{
    public Rgba32 Color { get; set; }

    public ColoredPoint(double x, double y, double z, Rgba32 color) : base(x, y, z)
    {
        Color = color;
    }

    public ColoredPoint(Rgba32 color) : this(0, 0, 0, color) { }

    public ColoredPoint(): this(0, 0, 0, new Rgba32(0,0,0)) { }

    public string GetColor()
    {
        return $"R: {Color.R}, G: {Color.G}, B: {Color.B}, A: {Color.A}";
    }
}