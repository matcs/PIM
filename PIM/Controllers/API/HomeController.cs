﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PIM.Controllers.API
{
    [Authorize]
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<bool>> IsValidToken()
        {
            return true;
        }

    }
}
