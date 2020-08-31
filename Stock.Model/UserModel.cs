using System.Collections;
using Stock.Entity;
using System.Collections.Generic;

namespace Stock.Model
{
    public class UserModel
    {
       private List<User> userList = new List<User>();

       public void insert(User user)
       {
           this.userList.Add(user);
       }

       public List<User> getList()
       {
           return this.userList;
       }
    }
}
