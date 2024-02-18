using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class User
    {
        public string Name { get; set; }
        public string Login { get; set; }

        public bool IsPremium { get; set; }
        public User(string name, string login, bool isPremium)
        {
            Name = name;
            Login = login;
            IsPremium = isPremium;
        }
    }
}
