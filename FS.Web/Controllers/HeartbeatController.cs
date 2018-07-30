using System.Web.Http;

namespace FS.Web.Controllers
{
    public class HeartbeatController : ApiController
    {
        [HttpGet]
        public void Ping()
        {
        }
    }
}