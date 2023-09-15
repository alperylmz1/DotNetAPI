using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Abstract
{
    public interface ITodoRepository
    {
        List<Todo> GetAllTodos();

        Todo GetTodoById(int id);

        Todo CreateTodo(Todo todo);

        Todo UpdateTodo(Todo todo);

        void DeleteTodo(int id);

        List<Todo> GetTodoByUserId(int id, string sortPref);
    }
}
