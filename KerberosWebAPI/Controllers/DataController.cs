using KerberosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KerberosWebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("data")]
    public class DataController : ApiController
    {
        [HttpPost]
        [Route("save")]
        public IHttpActionResult Save(PostData data)
        {
            return Ok(data.ToString());
        }
    }
}
