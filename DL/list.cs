using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheModel;

namespace DL
{
    public class list
    {
        List<User> users = new List<User>();
        public list()
        {
            CreateUserData();
        }

        private void CreateUserData()
        {
            User user1 = new User { userName = "Anne" };
            users.Add(user1);
            User user2 = new User { userName = "Irene" };
            users.Add(user2);
            User user3 = new User { userName = "Yoko" };
            users.Add(user3);

        }

        public User GetUser(string userName)
        {
            User found = new User();
            foreach (var user in users)
            {
                if (userName == user.userName)
                {
                    found = user;
                }
            }
            return found;
        }
    }
}
