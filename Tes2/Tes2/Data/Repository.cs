using System.Collections.Generic;
using System.Linq;
using Tes2.Models;

namespace Tes2.Data
{
    public class Repository : IRepository
    {
        private List<User> _users;

        public Repository()
        {
            _users = new List<User>
            {
                new User(){Id=1,Name="John",Role="admin"},
                new User(){Id=2,Name="Juan",Role="developer"},
                new User(){Id=3,Name="John",Role="user"}
            };
        }

        public List<User> GetUsers(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _users;
            }
            return _users.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}