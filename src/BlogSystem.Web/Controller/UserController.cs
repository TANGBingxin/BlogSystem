using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controller
{
    public class UserController : BaseController
    {
        public IUserServicer userServicer { get; set; }

        [HttpPost]
        public async Task<bool> RegistUser(UserCreateDto createDto)
        {
            return await userServicer.RegistUser(createDto);
        }
    }
}