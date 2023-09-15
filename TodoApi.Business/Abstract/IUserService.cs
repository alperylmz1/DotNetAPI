using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUser();

        User GetUserById(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);

        User LoginCheck(string userNameLogin, string passwordLogin);

        User ChangeUserUsername(Username username);

        User ChangeUserPassword(Password password);
    }
}
