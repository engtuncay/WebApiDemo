using System.Collections.Generic;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    [RoutePrefix("api/abr")]
    public class AbrController:ApiController
    {
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
    }
}