using Microsoft.AspNetCore.Mvc;

namespace MathUtilities.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AverageValController : ControllerBase
    {
        [HttpGet]


        public ActionResult<double> Get([FromQuery] List<int> data)
        {
            return data.Average();
        }
    
}
}
