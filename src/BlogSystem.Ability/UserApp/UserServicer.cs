using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using BlogSystem.Domain.AccountInfo;
using SharpCompress.Crypto;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Ability.UserApp
{
    public class UserServicer : AbilityServicer, IUserServicer
    {
        public required IRepository<User> UserRepository { get; set; }

        public async Task<LoginSuccessDto> CheckLogin(String userName, String password)
        {
            var user = await User.CheckLogin(userName, password, UserRepository);
            var loginUser = ModelMapper.Map<User, LoginSuccessDto>(user);
            loginUser.Token = Guid.NewGuid().ToString();
            return loginUser;
        }

        public async Task<bool> RegistUser(UserCreateDto createDto)
        {
            try
            {
                var user = ModelMapper.Map<UserCreateDto, User>(createDto);
                user.ValidateRegist();
                await UserRepository.InsertAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}