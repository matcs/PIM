using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PIM.Data;
using PIM.Models;
using PIM.Services;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PIM.Controllers.API
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            List<User> users = _context.Users.ToList();

            User user = null;

            foreach (var peoples in users)
            {
                if (peoples.Email.Equals(model.Email))
                    user = peoples;
            }

            if (user == null)
                return NotFound(new { message = "Usuário inválido" });
            if (!model.Password.Equals(user.Password))
                return NotFound(new { message = "Senha inválida" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";

            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            return new
            {

                User = user,
                Beaver = token,
                JsonPayload = tokenS.Payload
            };
        }

    }
}
