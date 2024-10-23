using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using BlogSystem.Ability.UserApp;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controller;

public class LoginController : BaseController
{
    public IUserServicer userServicer { get; set; }
    [HttpGet]
    public async Task<LoginSuccessDto> CheckLogin(String userName, String password)
    {
        return await userServicer.CheckLogin(userName, password);
    }
}
