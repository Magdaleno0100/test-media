using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_media.Data;
using api_media.Models;

namespace api_media.Repository
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            return new DataUser().Select();
        }

        public User GetUser()
        {
            return new User();
        }
    }
}
