using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tes2.Data;
using Tes2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tes2.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IRepository model;

        public UserController(IRepository repository)
        {
            model = repository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> users(string? name)
        {
            return model.GetUsers(name);
        }
    }
}