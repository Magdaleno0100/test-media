using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_media.Models;

namespace api_media.Data
{
    public class DataUser
    {
        List<User> users = new List<User>();
        public DataUser()
        {
            users.Add(new User() { Id = 1, Name = "User 1", Year = 20 });
            users.Add(new User() { Id = 2, Name = "User 2", Year = 21 });
            users.Add(new User() { Id = 3, Name = "User 3", Year = 20 });
        }

        public List<User> Select()
        {
            return users;
        }

        public User SelectUser()
        {
            return users[0];
        }
    }
}
