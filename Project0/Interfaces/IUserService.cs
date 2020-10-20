using System.Collections.Generic;
using System.Threading.Tasks;
using Project0.Models;

namespace Project0.Interfaces
{
    public interface IUserService
    {
        List<User> Get();
        Task<User> Get(string id);
        User Create(User user);
        void Update(string id, User userIn);
        void Remove(string id);
    }
}