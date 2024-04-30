using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.UserModel
{
    public interface IUserRepositoryAsync
    {
        Task<User> AddUserAsync(User user);
        Task<User> GetFirstUserByName(string name);
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(string id);
        Task<User> UpdateUserAsync(User user);
        Task RemoveUserAsync(string id);
    }
}
