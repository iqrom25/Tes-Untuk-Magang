using System.Collections.Generic;
using Tes2.Models;

namespace Tes2.Data
{
    public interface IRepository
    {
        List<User> GetUsers(string name);
    }
}