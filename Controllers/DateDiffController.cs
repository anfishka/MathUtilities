using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathUtilities.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
 public class DateDiffController : ControllerBase
    {
        [HttpGet]
        public int Get(DateTime date)
        {
            DateTime today = DateTime.Today;
            TimeSpan diff = today - date;
            return Math.Abs(diff.Days) + 1;
        }
    }
}
