using Stock.Entity;
using Stock.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Controller
{
    public class UserController
    {
        private UserModel userModel;

        public UserModel getModel()
        {
            if(this.userModel == null)
                this.userModel= new UserModel();
            return userModel;
        }

        public void setUser(UserModel userModel)
        {
            this.userModel = userModel;
        }
        

        public void create(int id, String username, String password, bool admin)
        {
            User u = new User(id,username,password,admin);
            this.getModel().insert(u);

        }

        public List<User> getList()
        {
            return this.getModel().getList();
        }
    }
}
