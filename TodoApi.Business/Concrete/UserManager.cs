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

        public UserManager()
        {
            _userRepository = new UserRepository();
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
    }
}
