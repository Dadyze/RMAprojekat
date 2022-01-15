using ProjekatRMA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA
{
    public static class UserData
    {
        public static List<UserObj> Users = new List<UserObj>();

        static UserData()
        {
            Users.Add(new UserObj("adin", "adin"));
        }
    }
}
