using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatRMA.Models
{
    public class UserObj
    {
        public UserObj(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; set; }
        public string Password { get; set; }

    }

}
