using PointLibrary;
using PointLibrary.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsController : ControllerBase
    {

        
        public readonly List<IPoint> _points;


        public PointsController(List<IPoint> points)
        {
            _points = points;
        }

        [HttpPost]
        public IActionResult AddPoint( [FromBody] Point point)
        {
            _points.Add(point);
            return Ok();
        }
        [HttpPost("colored")]
        public IActionResult AddColoredPoint([FromBody] ColoredPoint point)
        {
            _points.Add(point);
            return Ok();
        }


        [HttpGet]
        public IActionResult GetPoints()
        {
            return Ok(_points);
        }

        [HttpGet("colored")]
        public IActionResult GetColoredPoints()
        {
            return Ok(_points.OfType<ColoredPoint>());
        }
        
        [HttpGet("distance")]
        public  IActionResult GetDistance( [FromQuery]double X, [FromQuery] double Y, [FromQuery] double Z)
        {
            return Ok(_points.Select(p => {
                return new
                {
                    Distance = p.GetDistance(new Point(X, Y, Z)),
                    Point = p
                };
            }));
        }


    }
}
