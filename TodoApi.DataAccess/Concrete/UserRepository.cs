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


        public User LoginCheck(string userNameLogin, string passwordLogin)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var user = userDbContext.Users.FirstOrDefault(u => (u.UserMail == userNameLogin && u.UserPassword == passwordLogin));

                return user;
            }
        }

        /*
         public User ChangeUserName(User user)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var user_ = userDbContext.Users.FirstOrDefault(u => (u.UserMail == user.UserMail && u.UserPassword == user.UserPassword));

                if (user_ != null)
                {
                    user_.UserName = user.UserName;
                    //userDbContext.Entry(user_).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

                    userDbContext.Users.Update(user_);

                    //userDbContext.Attach(user);
                    //userDbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    userDbContext.SaveChanges();

                    return user;
                }
                else
                {
                    return null;
                }
                
            }
        }
        */

        /*
        public User ChangeUserPassword(User user, string userMailC, string userPasswordC)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var  user_ = userDbContext.Users.FirstOrDefault(a=>(userMailC == a.UserMail && userPasswordC == a.UserPassword));
               
                if (user_ != null)
                {
                    userDbContext.Entry(user_).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

                    userDbContext.Update(user);

                    userDbContext.Attach(user);
                    userDbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    userDbContext.SaveChanges();

                    return user;
                }
                else
                {
                    return null;
                }

            }
        }
        */
        public User ChangeUserPassword(Password password)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var user_ = userDbContext.Users.FirstOrDefault(p => (p.UserMail == password.UserMail && p.UserPassword == password.UserPassword));

                return user_;
                /*
                if (user_ != null)
                {
                    user_.UserPassword = password.NewUserPassword;

                    userDbContext.Users.Update(user_);
                    userDbContext.SaveChanges();

                    return user_;
                }
                else
                {
                    return null;
                }
                */
            }
        }

        public User ChangeUserUsername(Username username)
        {
            using (var userDbContext = new TodoDbContext())
            {
                var user_ = userDbContext.Users.FirstOrDefault(u => (u.UserMail == username.UserMail && u.UserPassword == username.UserPassword));

                return user_;
            }
        }



    }
}
