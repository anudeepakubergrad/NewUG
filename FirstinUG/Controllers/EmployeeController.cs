using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstinUG.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public string getData()
        {
            return "Helllo";
        }
    }
}
