using System;

namespace SpaDay.Models
{
    public class User
    {
        //Username, Email, and Password.

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Now { get; set; }


        public User(){}

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
