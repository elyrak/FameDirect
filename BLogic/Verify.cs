using DL;
using System;
using System.Collections.Generic;

namespace BLogic
{
    public class Verify
    {
        public bool verifyUser(string userName)
        {
            list Direc = new list();
            var result = Direc.GetUser(userName);

            return result.userName != null ? true : false;
        }

    }
}
