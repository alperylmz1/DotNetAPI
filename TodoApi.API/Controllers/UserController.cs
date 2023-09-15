using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Business.Abstract;
using TodoApi.Business.Concrete;
using TodoApi.Entities;

namespace TodoApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUser();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }
        
        [HttpPost]
        public User Post([FromBody]User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public User Put([FromBody]User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }

        [HttpPost("login")]
        public User PostLoginCheck([FromBody]User user)
        {
            user = _userService.LoginCheck(user.UserMail, user.UserPassword);
            return user;
        }

        /*
        [HttpPut("changeUserName")]
        public ActionResult<User> PutUserName([FromBody]User user)
        {
            user = _userService.ChangeUserUsername(user);

            if(user != null)
            {
                return StatusCode(200, user);  
            }
            else
            {
                return StatusCode(401);
            }
        }
        */

        /*
        [HttpPut("changePassword")]
        public ActionResult<User> PutUserPassword([FromBody]User user)
        {
            string mailHeader = Request.Headers["User-Mail"].ToString();
            string passwordHeader = Request.Headers["User-Password"].ToString();

            user = _userService.ChangeUserPassword(user, mailHeader, passwordHeader);

            if (user != null)
            {
                return StatusCode(200, user);
            }
            else
            {
                return StatusCode(401);
            }
        }
        */
        [HttpPost("changePassword")]
        public ActionResult<User> ChangePassword([FromBody]Password password)
        {
            var user = _userService.ChangeUserPassword(password);

            if (user != null)
            {
                return StatusCode(200, user);
            }
            else
            {
                return StatusCode(401);
            }
        }

        [HttpPost("changeUsername")]
        public ActionResult<User> ChangeUsername([FromBody]Username username)
        {
            var user = _userService.ChangeUserUsername(username);

            if (user != null)
            {
                return StatusCode(200, user);
            }
            else
            {
                return StatusCode(401);
            }
        }

    }
}