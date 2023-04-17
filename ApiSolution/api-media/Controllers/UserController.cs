using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using api_media.Models;
using api_media.Repository;

namespace api_media.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Get users test
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new UserRepository().GetUsers();
        }
        
        //Git Reset
    }
}
