using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Business.Abstract;
using TodoApi.DataAccess.Abstract;
using TodoApi.DataAccess.Concrete;
using TodoApi.Entities;

namespace TodoApi.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public User LoginCheck(string userNameLogin, string passwordLogin)
        {
            return _userRepository.LoginCheck(userNameLogin, passwordLogin);
        }

        public User ChangeUserUsername(Username username)
        {
            var user_ = _userRepository.ChangeUserUsername(username);

            if (user_ != null)
            {
                user_.UserName = username.NewUserName;

                _userRepository.UpdateUser(user_);

                return user_;
            }
            else
            {
                return null;
            }
        }

        public User ChangeUserPassword(Password password)
        {
            var user_ =  _userRepository.ChangeUserPassword(password);

            if (user_ != null)
            {
                user_.UserPassword = password.NewUserPassword;

                _userRepository.UpdateUser(user_);

                return user_;
            }
            else
            {
                return null;
            }
        }

    }
}
