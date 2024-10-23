using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("any")]
    public class BaseController : ControllerBase
    {

    }
}