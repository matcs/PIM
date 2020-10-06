using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PIM.Data;
using PIM.Models;
using PIM.Services;

namespace PIM.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context, ILogger<HomeController> logger)
        {
            _context = context;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            List<User> people = _context.People.ToList();

            User person = null;

            foreach (var peoples in people)
            {
                if (peoples.Email.Equals(model.Email))
                    person = peoples;
            }
          
            if (person == null)
                return NotFound(new { message = "Usuário inválido" });
            if (!model.Password.Equals(person.Password))
                return NotFound(new { message = "Senha inválida" });


            var token = TokenService.GenerateToken(person);
            person.Password = "";
            return new
            {
                User = person,
                Beaver = token
            };
        }

    }
}
