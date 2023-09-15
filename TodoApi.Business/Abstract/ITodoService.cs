using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.Business.Abstract
{
    public interface ITodoService
    {
        List<Todo> GetAllTodo();

        Todo GetTodoById(int id);

        Todo CreateTodo(Todo todo);

        Todo UpdateTodo(Todo todo);

        void DeleteTodo(int id);

        List <Todo> GetTodoByUserId(int userID, string sortPref);
    }
}
