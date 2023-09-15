using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Business.Abstract;
using TodoApi.DataAccess.Abstract;
using TodoApi.DataAccess.Concrete;
using TodoApi.Entities;

namespace TodoApi.Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private ITodoRepository _todoRepository;

        public TodoManager()
        {
            _todoRepository = new TodoRepository();
        }


        public Todo CreateTodo(Todo todo)
        {
            return _todoRepository.CreateTodo(todo);
        }

        public void DeleteTodo(int id)
        {
            _todoRepository.DeleteTodo(id);
        }

        public List<Todo> GetAllTodo()
        {
            return _todoRepository.GetAllTodos();
        }

        public Todo GetTodoById(int id)
        {
            return _todoRepository.GetTodoById(id);
        }

        public Todo UpdateTodo(Todo todo)
        {
            return _todoRepository.UpdateTodo(todo);
        }

        public List<Todo> GetTodoByUserId(int id, string sortPref)
        {
            return _todoRepository.GetTodoByUserId(id, sortPref);
        }
    }
}
