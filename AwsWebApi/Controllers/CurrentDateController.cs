using Microsoft.AspNetCore.Mvc;

namespace AwsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrentDateController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString("dd MMM yyyy hh:mm:ss");
        }
    }
}
