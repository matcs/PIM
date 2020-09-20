using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIM.Data;
using PIM.Models.PersonModel;
using PIM.Services;

namespace PIM.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly PIMContext _context;

        public HomeController(PIMContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] Person model)
        {
            List<Person> people = _context.People.ToList();

            Person person = null;

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

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";


    }
}
