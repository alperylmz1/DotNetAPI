using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApi.DataAccess.Abstract;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (var userDbContext = new TodoDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var deleteUser = GetUserById(id);
                userDbContext.Users.Remove(deleteUser);
                userDbContext.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var userDbContext = new TodoDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var userDbContext = new TodoDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new TodoDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }
    }
}
