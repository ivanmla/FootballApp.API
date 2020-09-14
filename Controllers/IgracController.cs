using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballBet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IgracController : ControllerBase
    {
        // GET api/igrac
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "igrač1", "igrač2" };
        }
    }
}
