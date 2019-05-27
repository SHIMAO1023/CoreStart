using CoreStart.Domain.Model;
using CoreStart.Dto;
using CoreStart.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreStart.Host.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody]UserDto user)
        {
            var result = this._userService.Create(user);
            return Content(result.ToString());
        }

        [HttpGet]
        public ActionResult<string> Get([FromQuery]int id)
        {
            return new JsonResult(_userService.Get(id));
        }
    }
}
