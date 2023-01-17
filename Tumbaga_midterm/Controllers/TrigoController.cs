using System;
using Microsoft.AspNetCore.Mvc;

namespace Tumbaga_midterm.Controllers
{
    [Route("Controllerss")]
    [ApiController]
    public class TrigController : ControllerBase
    {
        [HttpPost]
        public ActionResult<TrigResult> Post([FromBody] TrigInput input)
        {
            var sin = Math.Sin(input.Angle);
            var cos = Math.Cos(input.Angle);
            var tan = Math.Tan(input.Angle);
            var result = new TrigResult { Sin = sin, Cos = cos, Tan = tan };
            return result;
        }
    }
}