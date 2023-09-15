using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public class TodoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=GVY805; Database=ToDoDb; Integrated Security = true;");
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }    
        //public DbSet<Password> Passwords { get; set; }
        //public DbSet<Username> Usernames { get; set; }

    }
}
