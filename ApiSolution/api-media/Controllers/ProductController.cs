using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_media.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Get from Producto Controller";
        }
    }
}
