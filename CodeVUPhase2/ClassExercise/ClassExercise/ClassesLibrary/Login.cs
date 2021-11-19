using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Login
    {
        private string _username;
        private string _password;

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public Login() { }
        public Login(string username = "", string password = "")
        {
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return string.Format("Username: {0}\nPassword: {1}", Username, Password);
        }
    }
}
