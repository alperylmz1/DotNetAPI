using System;
using System.Collections.Generic;
using System.Linq;
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

        public UserController()
        {
            _userService = new UserManager();
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




    }
}