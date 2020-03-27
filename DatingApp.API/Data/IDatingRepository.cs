using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entitty) where T : class;
        void Delete<T>(T entitty) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}