using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controller
{
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("DevGet")]
        [Authorize(Roles = "admin")]
        public ActionResult<string> DevGet()
        {
            return "Yes, only Admin can accrss this API";
        }

        [HttpGet("UatGet")]
        [Authorize(Roles = "user")]
        public ActionResult<string> UatGet()
        {
            return "Yes, user can accrss this API";
        }

        [HttpGet("VisGet")]
        [Authorize(Roles = "visitor")]
        public ActionResult<string> VisitorGet()
        {
            return "Yes, visitor can accrss this API";
        }

        [HttpGet("Hi")]
        public ActionResult<string> SayHi()
        {
            return "Hi";
        }
    }
}
