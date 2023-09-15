using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApi.DataAccess.Abstract;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Concrete
{
    public class TodoRepository : ITodoRepository
    {
        public Todo CreateTodo(Todo todo)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                todoDbContext.Todos.Add(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }

        public void DeleteTodo(int id)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                var deleteTodo = GetTodoById(id);
                todoDbContext.Todos.Remove(deleteTodo);
                todoDbContext.SaveChanges();
            }
        }

        public List<Todo> GetAllTodos()
        {
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.Todos.OrderBy(a => a.TdFavorite).ToList();
            }
        }

        public Todo GetTodoById(int id)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.Todos.Find(id);
            }
        }

        public Todo UpdateTodo(Todo todo)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                todoDbContext.Todos.Update(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }

        public List<Todo> GetTodoByUserId(int id, string sortPref)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                if (sortPref == "0")
                {
                    return todoDbContext.Todos.Where(a => a.UserId == id).OrderByDescending(b => b.TdFavorite).ThenBy(c => c.EndDate).ToList();
                }
                else if(sortPref == "1")
                {
                    return todoDbContext.Todos.Where(a => a.UserId == id).OrderBy(b => b.EndDate).ThenByDescending(c => c.TdFavorite).ToList();
                }
                else
                {
                    return todoDbContext.Todos.Where(a => a.UserId == id).ToList();
                }
            }
        }

    }
}
