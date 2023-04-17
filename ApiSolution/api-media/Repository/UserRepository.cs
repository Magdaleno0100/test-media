using System.Collections.Generic;
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
    }
}
