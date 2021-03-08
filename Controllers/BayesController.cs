using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BayesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<BayesResponse> Create([FromBody] BayesRequest request)
        {
            return Ok(new BayesResponse());
        }
    }
}


public class BayesRequest
{
    public string Name { get; set; }
    public string Phone { get; set; }
}


public class BayesResponse
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; }
}