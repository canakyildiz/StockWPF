using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Admin { get; set; }

        public User()
        {

        }

        public User(int id, String userName, String password, bool admin)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.Admin = admin;
        }

    }
}
