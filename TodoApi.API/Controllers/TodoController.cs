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
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoManager();
        }


        [HttpGet]
        public List<Todo> Get()
        {
            return _todoService.GetAllTodo();
        }


        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return _todoService.GetTodoById(id);
        }


        [HttpPost]
        public Todo Post([FromBody]Todo todo)
        {
            return _todoService.CreateTodo(todo);
        }

        [HttpPut]
        public Todo Put([FromBody]Todo todo)
        {
            return _todoService.UpdateTodo(todo);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _todoService.DeleteTodo(id);
        }

        [HttpGet("user/{id}")]
        public List<Todo> GetByUser(int id, string sortPref)
        {
            string sortHeaderVal = Request.Headers["Sort-Pref"].ToString();

            

            return _todoService.GetTodoByUserId(id, sortHeaderVal);
        }

    }
}