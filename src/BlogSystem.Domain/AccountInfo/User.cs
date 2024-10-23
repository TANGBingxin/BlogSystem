using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Youshow.Ace.Domain.Models;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Domain.AccountInfo
{
    public class User : BaseModel<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegistTime { get; set; }

        public static async Task<User> CheckLogin(string userName, string password, IRepository<User> userRepo)
        {
            var user = await userRepo.GetAsync(u => u.UserName == userName && u.Password == password);
            return user;
        }

        public void ValidateRegist()
        {
            Regex regexPhoneNumber = new Regex(@"^-?[1-9]\d\d*$");
            if (!regexPhoneNumber.IsMatch(this.PhoneNumber))
            {
                throw new Exception("The format of phone number is wrong");
            }

            Regex regexEmail = new Regex("^(([^<>()[\\]\\.,;:\\s@\"]+(\\.[^<>()[\\]\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$");
            if (!regexEmail.IsMatch(this.Email))
            {
                throw new Exception("The format of email is wrong");
            }

            if (this.Birthday == null)
            {
                var defaultBirth = "2000-01-01";
                this.Birthday = DateTime.Parse(defaultBirth);
            }

            this.RegistTime = DateTime.Now;
        }
    }
}