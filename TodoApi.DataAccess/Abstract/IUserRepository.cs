using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);

    }
}
